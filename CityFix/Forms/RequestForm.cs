using System.Data;
using CityFix.Database;

namespace CityFix.Forms
{
    // Форма мешканця: створення нової заявки
    public partial class RequestForm : Form
    {
        private int categoryId = 0;     // 0 — категорію ще не обрано
        private int slaHours = 0;       // норматив виконання обраної категорії
        private byte[] photo = null;    // фото «До»

        public RequestForm()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            cmbDistrict.DisplayMember = "name";
            cmbDistrict.ValueMember = "id";
            cmbDistrict.DataSource = Db.GetDistricts();
            cmbDistrict.SelectedIndex = -1;

            AddNodes(treeCategories.Nodes, Db.GetCategories(), 0);
            treeCategories.ExpandAll();

            dtpCreated.Value = DateTime.Now;
        }

        // Будує дерево категорій: додає категорії з потрібним parent_id, а потім їхні підкатегорії
        private void AddNodes(TreeNodeCollection nodes, DataTable categories, int parentId)
        {
            foreach (DataRow row in categories.Rows)
            {
                int rowParent = 0;
                if (row["parent_id"] != DBNull.Value)
                    rowParent = Convert.ToInt32(row["parent_id"]);

                if (rowParent == parentId)
                {
                    TreeNode node = nodes.Add(row["name"].ToString());
                    node.Tag = row;   // запам'ятовуємо рядок, щоб потім знати id і SLA
                    AddNodes(node.Nodes, categories, Convert.ToInt32(row["id"]));
                }
            }
        }

        private void treeCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow row = (DataRow)e.Node.Tag;

            // Групи (ЖКГ, Електрика...) не мають SLA, обирати потрібно конкретну проблему
            if (row["sla_hours"] == DBNull.Value)
            {
                categoryId = 0;
                lblSelectedCategory.Text = "Оберіть конкретну проблему (кінцевий пункт дерева)";
                lblSla.Text = "Норматив виконання: —";
                lblDeadline.Text = "Кінцевий термін: —";
                return;
            }

            categoryId = Convert.ToInt32(row["id"]);
            slaHours = Convert.ToInt32(row["sla_hours"]);
            lblSelectedCategory.Text = "Обрано: " + e.Node.FullPath;
            lblSla.Text = "Норматив виконання: " + slaHours + " год";
            lblDeadline.Text = "Кінцевий термін: " + DateTime.Now.AddHours(slaHours).ToString("dd.MM.yyyy HH:mm");
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                photo = File.ReadAllBytes(openFileDialogPhoto.FileName);
                picPhoto.Image = Image.FromStream(new MemoryStream(photo));
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            photo = null;
            picPhoto.Image = null;
        }

        private void picPhoto_DoubleClick(object sender, EventArgs e)
        {
            if (picPhoto.Image != null)
                new PhotoViewForm(picPhoto.Image).ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtDescription.Text == "" ||
                cmbDistrict.SelectedIndex < 0 || categoryId == 0)
            {
                MessageBox.Show("Заповніть ім'я, район, адресу, опис і оберіть категорію проблеми.");
                return;
            }

            int id = Db.CreateRequest(txtName.Text, txtPhone.Text, Convert.ToInt32(cmbDistrict.SelectedValue),
                                      categoryId, txtAddress.Text, txtDescription.Text, slaHours, photo);

            MessageBox.Show("Заявку №" + id + " створено!\n" + lblDeadline.Text);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
