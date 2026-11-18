using System.Data;
using CityFix.Database;
using CityFix.Models;

namespace CityFix.Forms
{
    // Форма диспетчера: вкладка «Заявки» та вкладка «Склад матеріалів»
    public partial class DispatcherForm : Form
    {
        private List<Request> requests = new List<Request>();   // заявки, показані в таблиці

        public DispatcherForm()
        {
            InitializeComponent();
        }

        private void DispatcherForm_Load(object sender, EventArgs e)
        {
            cmbBrigades.DisplayMember = "title";
            cmbBrigades.ValueMember = "id";
            cmbBrigades.DataSource = Db.GetBrigades();

            cmbStatusFilter.SelectedIndex = 0;   // «Усі» — це одразу завантажить заявки
            LoadMaterials();
        }

        // ---------- Заявки ----------

        private void LoadRequests()
        {
            string filter = cmbStatusFilter.Text;

            // Залишаємо тільки заявки, які підходять під фільтр
            requests.Clear();
            foreach (Request r in Db.GetRequests())
            {
                if (filter == "Усі" || r.Status == filter || (filter == "Прострочені" && r.IsOverdue))
                    requests.Add(r);
            }

            DataTable table = new DataTable();
            table.Columns.Add("№");
            table.Columns.Add("Мешканець");
            table.Columns.Add("Район");
            table.Columns.Add("Категорія");
            table.Columns.Add("Статус");
            table.Columns.Add("Бригада");
            table.Columns.Add("Термін");
            table.Columns.Add("Прострочена");

            foreach (Request r in requests)
            {
                table.Rows.Add(r.Id, r.ResidentName, r.District, r.Category, r.Status, r.BrigadeName,
                               r.Deadline.ToString("dd.MM.yyyy HH:mm"), r.IsOverdue ? "Так" : "");
            }

            dgvRequests.DataSource = table;
            lblCount.Text = "Заявок: " + requests.Count;
        }

        // Після заповнення таблиці фарбуємо прострочені заявки в червоний колір
        private void dgvRequests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRequests.Rows)
            {
                if (row.Cells["Прострочена"].Value.ToString() == "Так")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
            }
        }

        // Повертає заявку, яку обрано в таблиці
        private Request GetSelectedRequest()
        {
            if (dgvRequests.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(dgvRequests.CurrentRow.Cells["№"].Value);
            foreach (Request r in requests)
            {
                if (r.Id == id)
                    return r;
            }
            return null;
        }

        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            Request r = GetSelectedRequest();
            if (r == null)
                return;

            lblRequestInfo.Text = "Заявка №" + r.Id + " (" + r.Status + ")\n" +
                                  "Мешканець: " + r.ResidentName + " " + r.Phone + "\n" +
                                  "Район: " + r.District + "\n" +
                                  "Адреса: " + r.Address + "\n" +
                                  "Категорія: " + r.Category + "\n" +
                                  "Опис: " + r.Description;

            dtpDeadline.Value = r.Deadline;
            lblTimeLeft.Text = r.TimeLeftText();
            lblTimeLeft.ForeColor = r.IsOverdue ? Color.Red : Color.Green;
            cmbNewStatus.Text = r.Status;

            picBefore.Image = Db.GetPhoto(r.Id, "before");
            picAfter.Image = Db.GetPhoto(r.Id, "after");
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            Request r = GetSelectedRequest();
            if (r == null)
                return;

            if (cmbNewStatus.Text == "Виконана")
            {
                MessageBox.Show("Статус «Виконана» встановлює майстер після завершення робіт.");
                return;
            }

            if (r.BrigadeName == "" && (cmbNewStatus.Text == "Призначена бригада" || cmbNewStatus.Text == "У роботі"))
            {
                MessageBox.Show("Спочатку призначте бригаду.");
                return;
            }

            Db.UpdateStatus(r.Id, cmbNewStatus.Text);
            LoadRequests();
            MessageBox.Show("Статус заявки №" + r.Id + " змінено.");
        }

        private void btnAssignBrigade_Click(object sender, EventArgs e)
        {
            Request r = GetSelectedRequest();
            if (r == null)
                return;

            if (r.Status == "Виконана" || r.Status == "Відхилена")
            {
                MessageBox.Show("Заявка вже закрита.");
                return;
            }

            Db.AssignBrigade(r.Id, Convert.ToInt32(cmbBrigades.SelectedValue));
            LoadRequests();
            MessageBox.Show("Бригаду призначено на заявку №" + r.Id + ".");
        }

        private void picBefore_DoubleClick(object sender, EventArgs e)
        {
            if (picBefore.Image != null)
                new PhotoViewForm(picBefore.Image).ShowDialog();
        }

        private void picAfter_DoubleClick(object sender, EventArgs e)
        {
            if (picAfter.Image != null)
                new PhotoViewForm(picAfter.Image).ShowDialog();
        }

        // ---------- Склад матеріалів ----------

        private void LoadMaterials()
        {
            dgvMaterials.DataSource = Db.GetMaterials();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (txtMatName.Text == "" || txtMatUnit.Text == "")
            {
                MessageBox.Show("Вкажіть назву та одиницю виміру.");
                return;
            }

            Db.AddMaterial(txtMatName.Text, txtMatUnit.Text, nudMatQty.Value, nudMatPrice.Value);
            LoadMaterials();
            txtMatName.Clear();
            txtMatUnit.Clear();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.CurrentRow == null || nudStockQty.Value <= 0)
            {
                MessageBox.Show("Оберіть матеріал у таблиці та вкажіть кількість.");
                return;
            }

            int materialId = Convert.ToInt32(dgvMaterials.CurrentRow.Cells["ID"].Value);
            Db.AddStock(materialId, nudStockQty.Value);
            LoadMaterials();
        }
    }
}
