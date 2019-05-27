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
    public partial class ManageArticlesForm : Form
    {
        private MainForm mainForm;
        public ManageArticlesForm()
        {
            InitializeComponent();
        }

        public ManageArticlesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
