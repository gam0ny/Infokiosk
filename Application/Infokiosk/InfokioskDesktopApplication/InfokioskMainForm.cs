using CustomControlLibrary;
using CustomControlLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        private BusinessLogicLayer businessLogicLayer;

        private BackgroundWorker backgroundWorker;

        #region Dynamic controls
        private InfokioskArticleForm infokioskArticleForm { get; set; }

        private Image noFileImage;

        private FlowLayoutPanel flowLayoutMainPanel { get; set; }
        #endregion

        #region Binded Models
        public List<ArticlePreviewModel> LatestArticles { get; set; } 

        public List<ArticlesByCategoryPreviewModel> ArticlesByCategoies { get; set; }

        #endregion

        public InfokioskMainForm()
        {
            businessLogicLayer = new BusinessLogicLayer();
            backgroundWorker = new BackgroundWorker();

            backgroundWorker.DoWork += new DoWorkEventHandler(FetchingLatestArticlesInProgress);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingLatestArticlesComplete);

            InitializeComponent();

            InitializeDynamicComponents();

            this.pbLoading.Visible = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void FetchingLatestArticlesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = businessLogicLayer.GetLatestArticles();
        }

        private void FetchingLatestArticlesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.LatestArticles = (List<ArticlePreviewModel>)e.Result;
            backgroundWorker.DoWork -= new DoWorkEventHandler(FetchingLatestArticlesInProgress);
            backgroundWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(FetchingLatestArticlesComplete);
            backgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticlesByCategoiesInProgress);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticlesByCategoiesComplete);
            backgroundWorker.RunWorkerAsync();

        }

        private void FetchingArticlesByCategoiesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = businessLogicLayer.GetArticlesByCategories();
        }

        private void FetchingArticlesByCategoiesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ArticlesByCategoies = (List<ArticlesByCategoryPreviewModel>)e.Result;
            DrawArticles();
            this.pbLoading.Visible = false;
        }

        private void DrawArticles()
        {
            var latestArticlesImageBoxView = new ImageBoxListView();
            this.flowLayoutMainPanel.Controls.Add(latestArticlesImageBoxView);

            latestArticlesImageBoxView.Title = "Новое";
            latestArticlesImageBoxView.NoFileImage = this.noFileImage;
            latestArticlesImageBoxView.MaximumSize = new Size(this.Size.Width - 200, 0);
            latestArticlesImageBoxView.ImageBoxItemList = Converter.FromArticlePreviewModelCollectionToImageBoxItemCollection(this.LatestArticles);
            latestArticlesImageBoxView.ImageBoxItemClick += HandleImageBoxItemClick;

            foreach(var articlesByCategory in this.ArticlesByCategoies)
            {
                var articlesByCategoryImageBoxView = new ImageBoxListView {
                    Title = articlesByCategory.Category,
                    NoFileImage = noFileImage,
                    //MaximumSize = new Size(this.Size.Width - 200, 0)
                };

                articlesByCategoryImageBoxView.ImageBoxItemClick += HandleImageBoxItemClick;
                articlesByCategoryImageBoxView.ImageBoxItemList = Converter.FromArticlePreviewModelCollectionToImageBoxItemCollection(articlesByCategory.Articles);
                this.flowLayoutMainPanel.Controls.Add(articlesByCategoryImageBoxView);
            }

            this.flowLayoutMainPanel.Focus();
        }

        private void InitializeDynamicComponents()
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            var noFileImagePath = ConfigurationManager.AppSettings["NoFileImagePath"];

            if(File.Exists(noFileImagePath))
            {
                this.noFileImage = Image.FromFile(noFileImagePath);
            }
            else
            {
                throw new FileNotFoundException("'NoFileImagePath' key in App.config is wrong");
            }

            this.flowLayoutMainPanel = new FlowLayoutPanel();
            this.flowLayoutMainPanel.AutoSize = true;
            this.flowLayoutMainPanel.FlowDirection = FlowDirection.TopDown;
            //this.flowLayoutMainPanel.AutoScroll = true;
            this.flowLayoutMainPanel.WrapContents = true;
            this.flowLayoutMainPanel.MaximumSize = new Size(this.Width - 100, this.Height);
            this.Controls.Add(flowLayoutMainPanel);
        }
        private void HandleImageBoxItemClick(object sender, EventArgs e)
        {
            var args = (CustomClickEventArgs)e;
            var ImageBox = args.ImageBox;
            infokioskArticleForm = new InfokioskArticleForm(this);
            infokioskArticleForm.ArticleId = ImageBox.Id;
            infokioskArticleForm.Title = ImageBox.Title;
            infokioskArticleForm.Category = ImageBox.Category;
            infokioskArticleForm.Show();
            this.Hide();
        }

        private void InfokioskMainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
