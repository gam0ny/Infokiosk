using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageArticlesForm : Form
    {
        private MainForm mainForm;

        private IController controller;

        private BackgroundWorker fetchArticlesBackgroundWorker;

        
        public ManageArticlesForm()
        {
            InitializeComponent();

            controller = new Controller();

            this.fetchArticlesBackgroundWorker = new BackgroundWorker();
            this.fetchArticlesBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticlesInProgress);
            this.fetchArticlesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticlessComplete);
        }

        public ManageArticlesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void FetchingArticlesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.GetArticles();
        }

        private void FetchingArticlessComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            var articles = (List<ArticlePreviewModel>)e.Result;

            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            var noImageFilwPath = ConfigurationManager.AppSettings["NoFileImagePath"];

            var gridArticles = new List<ArticleGridViewModel>();

            foreach(var article in articles)
            {
                var imagePreviewFullPath = string.Format("{0}{1}\\{2}", contentPath, article.Id, Path.GetFileName(article.ImageUrl));

                if(!File.Exists(imagePreviewFullPath))
                {
                    imagePreviewFullPath = noImageFilwPath;
                }

                var gridArticle = new ArticleGridViewModel
                {
                    Id = article.Id,
                    CategoryName = article.CategoryName,
                    Title = article.Title,
                    ImageUrl = article.ImageUrl,
                    HasDocument = article.HasDocument,
                    HasVideo = article.HasVideo,
                    PreviewImage = Image.FromFile(imagePreviewFullPath)
                };

                gridArticles.Add(gridArticle);
            }

            gvArticles.DataSource = gridArticles;

            pbLoading.Visible = false;
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

        private void ManageArticlesForm_Load(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            fetchArticlesBackgroundWorker.RunWorkerAsync();
        }

        private void PbLoading_Click(object sender, EventArgs e)
        {

        }

        private void GvArticles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GvArticles_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvArticles.Columns.Count; i++)
            {
                if (gvArticles.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)gvArticles.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
        }
    }
}
