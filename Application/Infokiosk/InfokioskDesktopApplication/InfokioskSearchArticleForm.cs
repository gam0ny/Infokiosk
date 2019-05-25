using CustomControlLibrary;
using CustomControlLibrary.Entities;
using InfokioskDesktopApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskSearchArticleForm : Form
    {
        public InfokioskMainForm InfokioskMainForm { get; set; }

        private BusinessLogicLayer businessLogicLayer;

        private BackgroundWorker backgroundWorker;

        private Image noFileImage;

        private ImageBoxListView foundArticlesImageBoxView;

        public List<ArticlePreviewModel> FoundArticles { get; set; }
        public InfokioskSearchArticleForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            businessLogicLayer = new BusinessLogicLayer();

            backgroundWorker = new BackgroundWorker();

            backgroundWorker.DoWork += InfokioskSearchArticle_InProgress;
            backgroundWorker.RunWorkerCompleted += InfokioskSearchArticle_Completed;

            var noFileImagePath = ConfigurationManager.AppSettings["NoFileImagePath"];

            if (File.Exists(noFileImagePath))
            {
                this.noFileImage = Image.FromFile(noFileImagePath);
            }
            else
            {
                throw new FileNotFoundException("'NoFileImagePath' key in App.config is wrong");
            }

            foundArticlesImageBoxView = new ImageBoxListView();
            this.panelSearchResult.Controls.Add(foundArticlesImageBoxView);
            foundArticlesImageBoxView.NoFileImage = this.noFileImage;
            foundArticlesImageBoxView.Visible = false;

        }

        public InfokioskSearchArticleForm(InfokioskMainForm mainForm) : this()
        {
            InfokioskMainForm = mainForm;
        }

        private void InfokioskSearchArticle_InProgress(object sender, DoWorkEventArgs e)
        {
            var keyword = e.Argument.ToString();
            if (rbName.Checked)
            {
                e.Result = businessLogicLayer.SearchArticlesByTitle(keyword);
            }

            if (rbContent.Checked)
            {
                e.Result = businessLogicLayer.SearchArticlesByContent(keyword);
            }
            
        }

        private void InfokioskSearchArticle_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            this.FoundArticles = (List<ArticlePreviewModel>)e.Result;
            this.btnSearch.Enabled = true;
            this.pbLoading.Visible = false;
            this.tbxSearch.Enabled = true;
            UpdateArticles();
            this.foundArticlesImageBoxView.Visible = true;
        }

        private void UpdateArticles()
        {
            foundArticlesImageBoxView.Title = this.FoundArticles.Count == 0 ? "К сожалению, ничего не найдено" : string.Format("{0} статей найдено", this.FoundArticles.Count);
            foundArticlesImageBoxView.MaximumSize = new Size(this.Size.Width - 200, 0);
            foundArticlesImageBoxView.ImageBoxItemList = Converter.FromArticlePreviewModelCollectionToImageBoxItemCollection(this.FoundArticles);
            foundArticlesImageBoxView.ImageBoxItemClick += HandleImageBoxItemClick;
        }

        private void HandleImageBoxItemClick(object sender, EventArgs e)
        {
            var args = (CustomClickEventArgs)e;
            var ImageBox = args.ImageBox;
            var infokioskArticleForm = new InfokioskArticleForm(this.InfokioskMainForm);
            infokioskArticleForm.ArticleModel.Id = ImageBox.Id;
            infokioskArticleForm.Show();
            this.Hide();
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

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            var value = ((TextBox)sender).Text;

            this.btnSearch.Enabled = !string.IsNullOrWhiteSpace(value);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                this.btnSearch.Enabled = false;
                this.pbLoading.Visible = true;
                this.tbxSearch.Enabled = false;
                this.foundArticlesImageBoxView.Visible = false;
                backgroundWorker.RunWorkerAsync(tbxSearch.Text);
            }
        }
    }
}
