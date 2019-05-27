using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageContentCategoriesForm : Form
    {
        private MainForm mainForm;
        public ManageContentCategoriesForm()
        {
            InitializeComponent();
        }

        public ManageContentCategoriesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void LblExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LblBack_Click(object sender, System.EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
