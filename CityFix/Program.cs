using CityFix.Forms;

namespace CityFix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Якщо в будь-якій формі станеться помилка (наприклад, MySQL не запущено),
            // програма не закриється, а покаже повідомлення
            Application.ThreadException += ShowError;

            Application.Run(new MainForm());
        }

        static void ShowError(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
