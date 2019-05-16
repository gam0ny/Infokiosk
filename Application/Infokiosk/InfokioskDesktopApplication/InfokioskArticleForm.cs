using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskArticleForm : Form
    {
        InfokioskMainForm InfokioskMainForm { get; set; }
        public string ArticleId { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }
        public InfokioskArticleForm()
        {
            InitializeComponent();
            this.webBrowser1.Visible = false;
        }

        public InfokioskArticleForm(InfokioskMainForm mainForm) : this()
        {
            InfokioskMainForm = mainForm;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfokioskArticleForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.lblTitle.Text = this.Title;
            this.lblCategory.Text = this.Category;
            //this.webBrowser1.DocumentText ="<html><body bgcolor='#696969'></body></html>";
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            this.webBrowser1.Url = new Uri(string.Format("{0}Articles/Древнейшие люди на белорусской земле.html", contentPath));
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Size = new Size(this.Width - 100, this.Height - 100);
            this.webBrowser1.Visible = true;
            this.webBrowser1.Focus();

        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            InfokioskMainForm.Show();
        }
    }
}
