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
        public InfokioskArticleForm()
        {
            InitializeComponent();
            this.webBrowser1.ScrollBarsEnabled = false;
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
            this.lblTitle.Text = "Архантропы (Homo erectus)";
            //this.webBrowser1.DocumentText ="<html><body bgcolor='#696969'></body></html>";
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            this.webBrowser1.Url = new Uri(string.Format("{0}Articles/Архантропы (Homo erectus).html", contentPath));
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Size = new Size(this.Width - 100, this.Height);
            this.webBrowser1.Visible = true;

        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            InfokioskMainForm.Show();
        }
    }
}
