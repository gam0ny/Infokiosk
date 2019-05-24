using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskSearchArticleForm : Form
    {
        public InfokioskMainForm InfokioskMainForm { get; set; }
        public InfokioskSearchArticleForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
        }

        public InfokioskSearchArticleForm(InfokioskMainForm mainForm) : this()
        {
            InfokioskMainForm = mainForm;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            this.InfokioskMainForm.Show();
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void TbxSearch_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutSearchInputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
