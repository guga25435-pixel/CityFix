using CityFix.Database;

namespace CityFix.Forms
{
    // Головна форма: перевірка підключення до бази та вибір ролі
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbBrigade.DisplayMember = "title";
                cmbBrigade.ValueMember = "id";
                cmbBrigade.DataSource = Db.GetBrigades();

                lblDbStatus.Text = "● Підключено до бази даних cityfix_db";
                lblDbStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblDbStatus.Text = "● Немає підключення до бази даних";
                lblDbStatus.ForeColor = Color.Red;
                MessageBox.Show("Запустіть MySQL у XAMPP і перевірте, що базу cityfix_db створено.\n\n" + ex.Message, "Помилка");
            }
        }

        private void btnResident_Click(object sender, EventArgs e)
        {
            new RequestForm().ShowDialog();
        }

        private void btnDispatcher_Click(object sender, EventArgs e)
        {
            new DispatcherForm().ShowDialog();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            if (cmbBrigade.SelectedValue == null)
            {
                MessageBox.Show("Оберіть бригаду майстра.");
                return;
            }
            new MasterForm(Convert.ToInt32(cmbBrigade.SelectedValue), cmbBrigade.Text).ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            new AnalyticsForm().ShowDialog();
        }
    }
}
