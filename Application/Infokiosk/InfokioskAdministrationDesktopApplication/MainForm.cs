using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class MainForm : Form
    {
        private ManageContentCategoriesForm manageContentCategoriesForm;

        private ManageArticlesForm manageArticlesForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnManageContentCategories_Click(object sender, EventArgs e)
        {
            manageContentCategoriesForm = new ManageContentCategoriesForm(this);
            manageContentCategoriesForm.Show();
            this.Hide();
        }

        private void BtnManageArticles_Click(object sender, EventArgs e)
        {
            manageArticlesForm = new ManageArticlesForm(this);
            manageArticlesForm.Show();
            this.Hide();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
