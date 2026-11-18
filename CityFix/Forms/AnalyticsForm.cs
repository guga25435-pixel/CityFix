using System.Data;
using System.Drawing.Imaging;
using CityFix.Database;
using CityFix.Models;
using ClosedXML.Excel;

namespace CityFix.Forms
{
    // Форма аналітики: показники, таблиці за районами та експорт в Excel
    public partial class AnalyticsForm : Form
    {
        private DataTable districts;   // заявки за районами
        private DataTable materials;   // витрати матеріалів за районами

        public AnalyticsForm()
        {
            InitializeComponent();
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Рахуємо показники циклом по всіх заявках
            List<Request> all = Db.GetRequests();
            int completed = 0, inWork = 0, overdue = 0;
            foreach (Request r in all)
            {
                if (r.Status == "Виконана") completed++;
                if (r.Status == "У роботі") inWork++;
                if (r.IsOverdue) overdue++;
            }

            lblTotal.Text = all.Count.ToString();
            lblCompleted.Text = completed.ToString();
            lblInWork.Text = inWork.ToString();
            lblOverdue.Text = overdue.ToString();

            int percent = all.Count == 0 ? 0 : completed * 100 / all.Count;
            progressCompleted.Value = percent;
            lblProgressPercent.Text = percent + "%";

            districts = Db.GetDistrictStats();
            dgvDistricts.DataSource = districts;

            materials = Db.GetMaterialCosts();
            dgvMaterialCosts.DataSource = materials;

            decimal totalCost = 0;
            foreach (DataRow row in materials.Rows)
                totalCost += Convert.ToDecimal(row["Вартість, грн"]);
            lblTotalCost.Text = "Загальна вартість матеріалів: " + totalCost.ToString("N2") + " грн";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialogExcel.FileName = "CityFix_звіт_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            if (saveFileDialogExcel.ShowDialog() != DialogResult.OK)
                return;

            ExportToExcel(saveFileDialogExcel.FileName);
            MessageBox.Show("Звіт збережено:\n" + saveFileDialogExcel.FileName);
        }

        // Створює Excel-файл звіту за допомогою ClosedXML
        private void ExportToExcel(string fileName)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Звіт");

                // 1-2. Назва звіту та дата формування
                sheet.Cell("A1").Value = "Звіт CityFix: міські заявки та витрати матеріалів";
                sheet.Cell("A1").Style.Font.Bold = true;
                sheet.Cell("A1").Style.Font.FontSize = 16;
                sheet.Cell("A2").Value = "Дата формування: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                // 3. Таблиця заявок за районами
                sheet.Cell("A4").Value = "Кількість заявок за районами";
                sheet.Cell("A4").Style.Font.Bold = true;
                sheet.Cell("A5").InsertTable(districts, "Districts");

                // 4. Таблиця використаних матеріалів (під першою таблицею)
                int row = 5 + districts.Rows.Count + 3;
                sheet.Cell(row, 1).Value = "Використані матеріали та витрати";
                sheet.Cell(row, 1).Style.Font.Bold = true;
                if (materials.Rows.Count > 0)
                    sheet.Cell(row + 1, 1).InsertTable(materials, "Materials");

                sheet.Columns().AdjustToContents();

                // 5. Графік. ClosedXML не вміє будувати діаграми Excel,
                // тому малюємо графік як картинку і вставляємо її на аркуш
                MemoryStream stream = new MemoryStream();
                DrawChart().Save(stream, ImageFormat.Png);
                stream.Position = 0;
                sheet.AddPicture(stream).MoveTo(sheet.Cell("G4"));

                workbook.SaveAs(fileName);
            }
        }

        // Малює стовпчиковий графік «Кількість заявок за районами»
        private Bitmap DrawChart()
        {
            Bitmap bitmap = new Bitmap(600, 350);
            Graphics g = Graphics.FromImage(bitmap);
            Font font = new Font("Segoe UI", 9);
            g.Clear(Color.White);
            g.DrawString("Розподіл заявок за районами", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, 20, 10);

            int max = 1;
            foreach (DataRow r in districts.Rows)
                max = Math.Max(max, Convert.ToInt32(r[1]));

            int bottom = 290;          // лінія, від якої ростуть стовпчики
            int maxHeight = 220;       // висота найвищого стовпчика
            int step = 560 / districts.Rows.Count;

            for (int i = 0; i < districts.Rows.Count; i++)
            {
                int count = Convert.ToInt32(districts.Rows[i][1]);
                int height = count * maxHeight / max;
                int x = 30 + i * step;

                g.FillRectangle(Brushes.SteelBlue, x, bottom - height, step - 15, height);
                g.DrawString(count.ToString(), font, Brushes.Black, x, bottom - height - 18);
                g.DrawString(districts.Rows[i][0].ToString(), font, Brushes.Black, new RectangleF(x - 5, bottom + 5, step, 40));
            }
            g.DrawLine(Pens.Gray, 20, bottom, 590, bottom);
            g.Dispose();
            return bitmap;
        }
    }
}
