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
    public enum Action
    {
        FetchLatestArticles,
        FetchArticlesGroupedByContentCategory
    }
    public partial class InfokioskMainForm : Form
    {
        private BusinessLogicLayer businessLogicLayer;

        private BackgroundWorker backgroundWorker;

        #region Dynamic controls
        private InfokioskArticleForm infokioskArticleForm { get; set; }

        private ImageBoxListView latestArticlesImageBoxView;

        private FlowLayoutPanel flowLayoutPanel;
        #endregion

        #region Binded Models
        public List<ArticlePreviewModel> LatestArticles { get; set; } 

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
            backgroundWorker.RunWorkerAsync(Action.FetchLatestArticles);
        }

        private void FetchingLatestArticlesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = businessLogicLayer.GetLatestArticles();
        }

        private void FetchingLatestArticlesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbLoading.Visible = false;
            this.LatestArticles = (List<ArticlePreviewModel>)e.Result;
            this.latestArticlesImageBoxView.Title = "Новое";
            this.latestArticlesImageBoxView.ImageBoxItemList = Converter.FromArticlePreviewModelCollectionToImageBoxItemCollection(this.LatestArticles);
            this.latestArticlesImageBoxView.Refresh();
        }

        private void InitializeDynamicComponents()
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            var noFileImagePath = ConfigurationManager.AppSettings["NoFileImagePath"];
            Image noFileImage = null;

            if(File.Exists(noFileImagePath))
            {
                noFileImage = Image.FromFile(noFileImagePath);
            }
            else
            {
                throw new FileNotFoundException("'NoFileImagePath' key in App.config is wrong");
            }

            this.latestArticlesImageBoxView = new ImageBoxListView()
            {
                Title = "Новое",
                NoFileImage = noFileImage,
                MaximumSize = new Size(this.Size.Width - 200, this.Size.Height- 200),
            };

            this.latestArticlesImageBoxView.ImageBoxItemClick += HandleImageBoxItemClick;
            this.Controls.Add(latestArticlesImageBoxView);
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
            this.flowLayoutPanel.MinimumSize = new Size(this.Width - 80, this.Height - this.latestArticlesImageBoxView.Height - 80);
            this.flowLayoutPanel.Location = new Point(-3, this.latestArticlesImageBoxView.Height);
            this.flowLayoutPanel.Focus();


        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
