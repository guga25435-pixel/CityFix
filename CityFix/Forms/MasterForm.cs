using System.Data;
using CityFix.Database;
using CityFix.Models;

namespace CityFix.Forms
{
    // Форма майстра: заявки бригади, фото «Після», списання матеріалів, завершення
    public partial class MasterForm : Form
    {
        private int brigadeId;
        private List<Request> requests = new List<Request>();
        private DataTable usedMaterials = new DataTable();   // матеріали, які майстер вказав для заявки
        private byte[] afterPhoto = null;

        public MasterForm(int brigadeId, string brigadeTitle)
        {
            InitializeComponent();
            this.brigadeId = brigadeId;
            lblBrigadeInfo.Text = brigadeTitle;
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            usedMaterials.Columns.Add("ID", typeof(int));
            usedMaterials.Columns.Add("Матеріал");
            usedMaterials.Columns.Add("Кількість", typeof(decimal));
            usedMaterials.Columns.Add("Од.");
            dgvUsedMaterials.DataSource = usedMaterials;
            dgvUsedMaterials.Columns["ID"].Visible = false;

            LoadData();
        }

        private void LoadData()
        {
            cmbMaterials.DisplayMember = "Назва";
            cmbMaterials.ValueMember = "ID";
            cmbMaterials.DataSource = Db.GetMaterials();

            requests = Db.GetBrigadeRequests(brigadeId);

            DataTable table = new DataTable();
            table.Columns.Add("№");
            table.Columns.Add("Адреса");
            table.Columns.Add("Категорія");
            table.Columns.Add("Статус");
            table.Columns.Add("Термін");
            foreach (Request r in requests)
            {
                table.Rows.Add(r.Id, r.Address, r.Category, r.Status, r.TimeLeftText());
            }
            dgvMyRequests.DataSource = table;

            if (requests.Count == 0)
            {
                lblInfo.Text = "Для вашої бригади немає активних заявок.";
                picBefore.Image = null;
                progressWork.Value = 0;
                lblStageText.Text = "—";
                btnStartWork.Enabled = false;
                btnComplete.Enabled = false;
            }
        }

        private Request GetSelectedRequest()
        {
            if (dgvMyRequests.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(dgvMyRequests.CurrentRow.Cells["№"].Value);
            foreach (Request r in requests)
            {
                if (r.Id == id)
                    return r;
            }
            return null;
        }

        // Обрали іншу заявку — показуємо її дані та очищаємо фото «Після» і список матеріалів
        private void dgvMyRequests_SelectionChanged(object sender, EventArgs e)
        {
            afterPhoto = null;
            picAfter.Image = null;
            usedMaterials.Rows.Clear();

            Request r = GetSelectedRequest();
            if (r == null)
                return;

            lblInfo.Text = "Заявка №" + r.Id + "\n" +
                           "Мешканець: " + r.ResidentName + " " + r.Phone + "\n" +
                           "Адреса: " + r.District + ", " + r.Address + "\n" +
                           "Категорія: " + r.Category + "\n" +
                           "Кінцевий термін: " + r.Deadline.ToString("dd.MM.yyyy HH:mm") + " (" + r.TimeLeftText() + ")\n" +
                           "Опис: " + r.Description;

            picBefore.Image = Db.GetPhoto(r.Id, "before");

            if (r.Status == "У роботі")
            {
                progressWork.Value = 66;
                lblStageText.Text = "Роботи виконуються — додайте фото «Після» та матеріали";
            }
            else
            {
                progressWork.Value = 33;
                lblStageText.Text = "Бригаду призначено — натисніть «Почати роботу»";
            }

            btnStartWork.Enabled = r.Status == "Призначена бригада";
            btnComplete.Enabled = r.Status == "У роботі";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            Request r = GetSelectedRequest();
            if (r == null)
                return;

            Db.UpdateStatus(r.Id, "У роботі");
            LoadData();
        }

        private void btnAddAfterPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                afterPhoto = File.ReadAllBytes(openFileDialogPhoto.FileName);
                picAfter.Image = Image.FromStream(new MemoryStream(afterPhoto));
            }
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

        // Показуємо одиницю виміру та залишок обраного матеріалу
        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView material = cmbMaterials.SelectedItem as DataRowView;
            if (material != null)
                lblUnit.Text = material["Од. виміру"] + " (є " + material["Кількість"] + ")";
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            DataRowView material = cmbMaterials.SelectedItem as DataRowView;
            if (material == null || nudQty.Value <= 0)
            {
                MessageBox.Show("Оберіть матеріал і вкажіть кількість.");
                return;
            }

            if (nudQty.Value > Convert.ToDecimal(material["Кількість"]))
            {
                MessageBox.Show("На складі недостатньо цього матеріалу.");
                return;
            }

            usedMaterials.Rows.Add(material["ID"], material["Назва"], nudQty.Value, material["Од. виміру"]);
            nudQty.Value = 0;
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (dgvUsedMaterials.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dgvUsedMaterials.CurrentRow.DataBoundItem;
                row.Row.Delete();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Request r = GetSelectedRequest();
            if (r == null)
                return;

            if (afterPhoto == null)
            {
                MessageBox.Show("Додайте фото «Після».");
                return;
            }

            Db.CompleteRequest(r.Id, usedMaterials, afterPhoto);
            MessageBox.Show("Заявку №" + r.Id + " виконано, матеріали списано зі складу.");
            LoadData();
        }
    }
}
