using System.Data;
using CityFix.Models;
using MySqlConnector;

namespace CityFix.Database
{
    // Підключення до MySQL (XAMPP) і всі SQL-запити програми
    public static class Db
    {
        // root без пароля — стандартний користувач XAMPP
        private const string ConnectionString = "Server=localhost;Port=3306;Database=cityfix_db;User ID=root;Password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        // Виконує SELECT без параметрів і повертає результат як таблицю (для ComboBox і DataGridView)
        public static DataTable GetTable(string sql)
        {
            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
        }

        // ---------- Довідники ----------

        public static DataTable GetDistricts()
        {
            return GetTable("SELECT id, name FROM districts ORDER BY name");
        }

        public static DataTable GetCategories()
        {
            return GetTable("SELECT id, name, parent_id, sla_hours FROM categories ORDER BY id");
        }

        public static DataTable GetBrigades()
        {
            return GetTable("SELECT id, CONCAT(name, ' — ', master_name) AS title FROM brigades ORDER BY id");
        }

        public static DataTable GetMaterials()
        {
            return GetTable("SELECT id AS `ID`, name AS `Назва`, quantity AS `Кількість`, unit AS `Од. виміру`, price AS `Ціна, грн` " +
                            "FROM materials ORDER BY name");
        }

        // ---------- Заявки ----------

        private const string RequestsSql =
            "SELECT r.id, res.full_name, res.phone, d.name AS district, c.name AS category, r.address, r.description, " +
            "r.status, b.name AS brigade, r.created_at, r.deadline " +
            "FROM requests r " +
            "JOIN residents res ON r.resident_id = res.id " +
            "JOIN districts d ON r.district_id = d.id " +
            "JOIN categories c ON r.category_id = c.id " +
            "LEFT JOIN brigades b ON r.brigade_id = b.id ";   // LEFT JOIN — бо бригади може ще не бути

        // Усі заявки (для диспетчера та аналітики)
        public static List<Request> GetRequests()
        {
            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(RequestsSql + "ORDER BY r.created_at DESC", connection))
            {
                return ReadRequests(command);
            }
        }

        // Активні заявки однієї бригади (для майстра)
        public static List<Request> GetBrigadeRequests(int brigadeId)
        {
            string sql = RequestsSql + "WHERE r.brigade_id = @brigade AND r.status IN ('Призначена бригада', 'У роботі') ORDER BY r.deadline";
            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@brigade", brigadeId);
                return ReadRequests(command);
            }
        }

        // Перетворює рядки результату запиту на список об'єктів Request
        private static List<Request> ReadRequests(MySqlCommand command)
        {
            List<Request> list = new List<Request>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Request r = new Request();
                    r.Id = Convert.ToInt32(reader["id"]);
                    r.ResidentName = reader["full_name"].ToString();
                    r.Phone = reader["phone"].ToString();
                    r.District = reader["district"].ToString();
                    r.Category = reader["category"].ToString();
                    r.Address = reader["address"].ToString();
                    r.Description = reader["description"].ToString();
                    r.Status = reader["status"].ToString();
                    r.BrigadeName = reader["brigade"].ToString();   // NULL перетвориться на ""
                    r.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    r.Deadline = Convert.ToDateTime(reader["deadline"]);
                    list.Add(r);
                }
            }
            return list;
        }

        // Створення заявки мешканцем. Кінцевий термін = зараз + норматив SLA категорії.
        public static int CreateRequest(string name, string phone, int districtId, int categoryId,
                                        string address, string description, int slaHours, byte[] photo)
        {
            DateTime createdAt = DateTime.Now;
            DateTime deadline = createdAt.AddHours(slaHours);   // розрахунок SLA

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand resident = new MySqlCommand("INSERT INTO residents (full_name, phone) VALUES (@name, @phone)", connection);
                resident.Parameters.AddWithValue("@name", name);
                resident.Parameters.AddWithValue("@phone", phone);
                resident.ExecuteNonQuery();

                MySqlCommand request = new MySqlCommand(
                    "INSERT INTO requests (resident_id, district_id, category_id, address, description, status, created_at, deadline) " +
                    "VALUES (@resident, @district, @category, @address, @description, 'Нова', @created, @deadline)", connection);
                request.Parameters.AddWithValue("@resident", resident.LastInsertedId);
                request.Parameters.AddWithValue("@district", districtId);
                request.Parameters.AddWithValue("@category", categoryId);
                request.Parameters.AddWithValue("@address", address);
                request.Parameters.AddWithValue("@description", description);
                request.Parameters.AddWithValue("@created", createdAt);
                request.Parameters.AddWithValue("@deadline", deadline);
                request.ExecuteNonQuery();

                int requestId = (int)request.LastInsertedId;
                if (photo != null)
                    SavePhoto(connection, null, requestId, "before", photo);
                return requestId;
            }
        }

        public static void UpdateStatus(int requestId, string status)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("UPDATE requests SET status = @status WHERE id = @id", connection);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@id", requestId);
                command.ExecuteNonQuery();
            }
        }

        public static void AssignBrigade(int requestId, int brigadeId)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE requests SET brigade_id = @brigade, status = 'Призначена бригада' WHERE id = @id", connection);
                command.Parameters.AddWithValue("@brigade", brigadeId);
                command.Parameters.AddWithValue("@id", requestId);
                command.ExecuteNonQuery();
            }
        }

        // Завершення заявки майстром: списання матеріалів + фото «Після» + статус «Виконана».
        // Усе в одній транзакції: якщо якогось матеріалу не вистачить, нічого не збережеться.
        public static void CompleteRequest(int requestId, DataTable usedMaterials, byte[] afterPhoto)
        {
            using (MySqlConnection connection = GetConnection())
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                foreach (DataRow row in usedMaterials.Rows)
                {
                    int materialId = Convert.ToInt32(row["ID"]);
                    decimal quantity = Convert.ToDecimal(row["Кількість"]);

                    // Перевіряємо залишок на складі
                    MySqlCommand check = new MySqlCommand("SELECT quantity FROM materials WHERE id = @id", connection, transaction);
                    check.Parameters.AddWithValue("@id", materialId);
                    decimal stock = Convert.ToDecimal(check.ExecuteScalar());
                    if (quantity > stock)
                        throw new Exception("Недостатньо матеріалу «" + row["Матеріал"] + "». На складі: " + stock);

                    // Зменшуємо залишок
                    MySqlCommand update = new MySqlCommand("UPDATE materials SET quantity = quantity - @qty WHERE id = @id", connection, transaction);
                    update.Parameters.AddWithValue("@qty", quantity);
                    update.Parameters.AddWithValue("@id", materialId);
                    update.ExecuteNonQuery();

                    // Записуємо, що матеріал використано на цю заявку
                    MySqlCommand insert = new MySqlCommand(
                        "INSERT INTO request_materials (request_id, material_id, quantity, used_at) VALUES (@request, @material, @qty, NOW())",
                        connection, transaction);
                    insert.Parameters.AddWithValue("@request", requestId);
                    insert.Parameters.AddWithValue("@material", materialId);
                    insert.Parameters.AddWithValue("@qty", quantity);
                    insert.ExecuteNonQuery();
                }

                SavePhoto(connection, transaction, requestId, "after", afterPhoto);

                MySqlCommand done = new MySqlCommand("UPDATE requests SET status = 'Виконана', completed_at = NOW() WHERE id = @id",
                                                     connection, transaction);
                done.Parameters.AddWithValue("@id", requestId);
                done.ExecuteNonQuery();

                // Якщо вище виникла помилка, Commit не виконається і транзакція скасується автоматично
                transaction.Commit();
            }
        }

        // ---------- Фото (BLOB) ----------

        private static void SavePhoto(MySqlConnection connection, MySqlTransaction transaction, int requestId, string type, byte[] photo)
        {
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO request_photos (request_id, photo_type, photo_data, uploaded_at) VALUES (@request, @type, @data, NOW())",
                connection, transaction);
            command.Parameters.AddWithValue("@request", requestId);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.Add("@data", MySqlDbType.LongBlob).Value = photo;   // масив байтів → LONGBLOB
            command.ExecuteNonQuery();
        }

        // Завантажує фото з бази. type: "before" — до ремонту, "after" — після. Якщо фото немає — null.
        public static Image GetPhoto(int requestId, string type)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT photo_data FROM request_photos WHERE request_id = @request AND photo_type = @type ORDER BY id DESC LIMIT 1",
                    connection);
                command.Parameters.AddWithValue("@request", requestId);
                command.Parameters.AddWithValue("@type", type);

                object result = command.ExecuteScalar();
                if (result == null)
                    return null;

                byte[] bytes = (byte[])result;
                return Image.FromStream(new MemoryStream(bytes));   // байти → картинка для PictureBox
            }
        }

        // ---------- Склад ----------

        public static void AddMaterial(string name, string unit, decimal quantity, decimal price)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO materials (name, quantity, unit, price) VALUES (@name, @qty, @unit, @price)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@qty", quantity);
                command.Parameters.AddWithValue("@unit", unit);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
            }
        }

        public static void AddStock(int materialId, decimal quantity)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("UPDATE materials SET quantity = quantity + @qty WHERE id = @id", connection);
                command.Parameters.AddWithValue("@qty", quantity);
                command.Parameters.AddWithValue("@id", materialId);
                command.ExecuteNonQuery();
            }
        }

        // ---------- Аналітика ----------

        public static DataTable GetDistrictStats()
        {
            return GetTable(
                "SELECT d.name AS `Район`, COUNT(r.id) AS `Усього заявок`, " +
                "SUM(CASE WHEN r.status = 'Виконана' THEN 1 ELSE 0 END) AS `Виконано` " +
                "FROM districts d LEFT JOIN requests r ON r.district_id = d.id " +
                "GROUP BY d.id, d.name ORDER BY `Усього заявок` DESC");
        }

        public static DataTable GetMaterialCosts()
        {
            return GetTable(
                "SELECT d.name AS `Район`, m.name AS `Матеріал`, SUM(rm.quantity) AS `Кількість`, m.unit AS `Од. виміру`, " +
                "SUM(rm.quantity * m.price) AS `Вартість, грн` " +
                "FROM request_materials rm " +
                "JOIN requests r ON rm.request_id = r.id " +
                "JOIN districts d ON r.district_id = d.id " +
                "JOIN materials m ON rm.material_id = m.id " +
                "GROUP BY d.name, m.name, m.unit ORDER BY d.name, m.name");
        }
    }
}
