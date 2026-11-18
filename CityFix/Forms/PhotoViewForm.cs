namespace CityFix.Forms
{
    // Окреме вікно для збільшеного перегляду фото (вікно можна розгорнути на весь екран)
    public partial class PhotoViewForm : Form
    {
        public PhotoViewForm(Image image)
        {
            InitializeComponent();
            picLarge.Image = image;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
