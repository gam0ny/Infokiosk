using System;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class MainForm : Form, IAuthorizedForm
    {
        private ManageContentCategoriesForm manageContentCategoriesForm;

        private ManageArticlesForm manageArticlesForm;

        public Guid? UserId { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnManageContentCategories_Click(object sender, EventArgs e)
        {
            manageContentCategoriesForm = new ManageContentCategoriesForm(this);
            manageContentCategoriesForm.UserId = this.UserId;
            manageContentCategoriesForm.Show();
            this.Hide();
        }

        private void BtnManageArticles_Click(object sender, EventArgs e)
        {
            manageArticlesForm = new ManageArticlesForm(this);
            manageArticlesForm.UserId = this.UserId;
            manageArticlesForm.Show();
            this.Hide();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
