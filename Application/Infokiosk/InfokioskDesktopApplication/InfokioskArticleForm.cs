using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskArticleForm : Form
    {
        private IInfokioskDesktopApplicationController controller;

        private BackgroundWorker backgroundWorker;

        InfokioskMainForm InfokioskMainForm { get; set; }

        public ArticleModel ArticleModel { get; set; }

        private SendCompletedEventHandler emailSendEventHandler;

        public InfokioskArticleForm()
        {
            InitializeComponent();
            this.webBrowser1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.controller = new InfokioskDesktopApplicationController();

            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticleContentByIdInProgress);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticleContentByIdComplete);

            this.ArticleModel = new ArticleModel();

            this.emailSendEventHandler += Email_SendAsyncEventHandler;
        }

        public InfokioskArticleForm(InfokioskMainForm mainForm) : this()
        {
            InfokioskMainForm = mainForm;
        }

        private void FetchingArticleContentByIdInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.GetArticleById(this.ArticleModel.Id);
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
            this.webBrowser1.Size = new Size(this.Width - this.panelToolbar.Width - 100, this.Height - this.panelEmail.Height - 50);

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

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            pbEmailSendingLoading.Visible = true;
            lblEmailMessage.Visible = false;
            controller.SendEmail(tbxEmail.Text, this.ArticleModel, this.emailSendEventHandler);
        }

        private void Email_SendAsyncEventHandler(object sender, AsyncCompletedEventArgs args)
        {
            pbEmailSendingLoading.Visible = false;
            lblEmailMessage.Visible = true;
        }

        private void TbxEmail_TextChanged(object sender, EventArgs e)
        {
            var value = ((TextBox)sender).Text;
            btnSendEmail.Enabled = !string.IsNullOrWhiteSpace(value);
            lblEmailMessage.Visible = false;
        }
    }
}
