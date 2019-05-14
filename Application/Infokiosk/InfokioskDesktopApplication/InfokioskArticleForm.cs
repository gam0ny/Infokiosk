using System;
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
            this.webBrowser1.Url = new Uri("c:/Users/ruslan/Desktop/Инфокиоск для выстовочного отдела/_Content/Articles/Архантропы (Homo erectus).html");
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //If dockstyle = fill
            this.Width = webBrowser1.Document.Body.ScrollRectangle.Width + 40;
            this.Height = webBrowser1.Document.Body.ScrollRectangle.Height + 40;
            webBrowser1.Size = webBrowser1.Document.Body.ScrollRectangle.Size;
            this.webBrowser1.Visible = true;

        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            InfokioskMainForm.Show();
        }
    }
}
