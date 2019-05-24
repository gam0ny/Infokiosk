using InfokioskDesktopApplication.Models;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskArticleForm : Form
    {
        private BusinessLogicLayer businessLogicLayer;

        private BackgroundWorker backgroundWorker;

        InfokioskMainForm InfokioskMainForm { get; set; }

        public ArticleModel ArticleModel { get; set; }

        public InfokioskArticleForm()
        {
            InitializeComponent();
            this.webBrowser1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.businessLogicLayer = new BusinessLogicLayer();

            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticleContentByIdInProgress);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticleContentByIdComplete);

            this.ArticleModel = new ArticleModel();
        }

        public InfokioskArticleForm(InfokioskMainForm mainForm) : this()
        {
            InfokioskMainForm = mainForm;
        }

        private void FetchingArticleContentByIdInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = businessLogicLayer.GetArticleById(this.ArticleModel.Id);
        }

        private void FetchingArticleContentByIdComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            this.ArticleModel = (ArticleModel)e.Result;
            this.lblTitle.Text = this.ArticleModel.Title;
            this.lblCategory.Text = this.ArticleModel.CategoryName.ToUpper();
            this.webBrowser1.DocumentText = this.ArticleModel.Content.Replace("src=\"", string.Format("src=\"{0}{1}\\", contentPath, ArticleModel.Id));
            this.pbLoading.Visible = false;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Visible = true;
            this.webBrowser1.Focus();
            this.webBrowser1.Size = new Size(this.Width - 100, this.Height - 100);

        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            InfokioskMainForm.Show();
            this.Close();
        }

        private void InfokioskArticleForm_Load(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }
    }
}
