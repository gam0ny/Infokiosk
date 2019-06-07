using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using InfokioskAdministrationDesktopApplication.UiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageArticlesForm : Form, IAuthorizedForm
    {
        private MainForm mainForm;

        private IController controller;

        private BackgroundWorker fetchArticlesBackgroundWorker;
        private BackgroundWorker deleteArticleBackgroundWorker;

        public Guid? UserId { get; set; }

        public ManageArticlesForm()
        {
            InitializeComponent();

            controller = new Controller();

            this.fetchArticlesBackgroundWorker = new BackgroundWorker();
            this.fetchArticlesBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticlesInProgress);
            this.fetchArticlesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticlessComplete);

            this.deleteArticleBackgroundWorker = new BackgroundWorker();
            this.deleteArticleBackgroundWorker.DoWork += new DoWorkEventHandler(DeleteArticleInProgress);
            this.deleteArticleBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DeleteArticleComplete);
        }

        public ManageArticlesForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
            this.UserId = mainForm.UserId;
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

            foreach (var article in articles)
            {
                var imagePreviewFullPath = string.Format("{0}{1}\\{2}", contentPath, article.Id, Path.GetFileName(article.ImageUrl));

                if (!File.Exists(imagePreviewFullPath))
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

        private void DeleteArticleInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.DeleteArticle((ArticlePreviewModel)e.Argument);
        }

        private void DeleteArticleComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pbLoading.Visible = false;

            bool result = (bool)e.Result;

            if (result)
            {
                this.pbLoading.Visible = true;
                this.fetchArticlesBackgroundWorker.RunWorkerAsync();
            }
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

        private void GvArticles_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = ((DataGridView)sender).SelectedRows.Count > 0;
            btnDelete.Enabled = ((DataGridView)sender).SelectedRows.Count > 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить статью? Удаленная тема не будет доступна в пользовательском инфокиоске!", "Внимание!", MessageBoxButtons.YesNo);

            if (result.ToString().ToUpper() == "Yes".ToUpper())
            {
                pbLoading.Visible = true;
                if (gvArticles.SelectedRows.Count > 0)
                {
                    var selectedArticle = (ArticleGridViewModel)gvArticles.SelectedRows[0].DataBoundItem;
                    deleteArticleBackgroundWorker.RunWorkerAsync(new ArticlePreviewModel
                    {
                        CategoryName = selectedArticle.CategoryName,
                        HasDocument = selectedArticle.HasDocument,
                        HasVideo = selectedArticle.HasVideo,
                        Id = selectedArticle.Id,
                        ImageUrl = selectedArticle.ImageUrl,
                        Title = selectedArticle.Title
                    });
                }
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var manageArticleForm = new ManageArticleForm(this);
            manageArticleForm.Show();
            this.Hide();
        }

        private void ManageArticlesForm_Paint(object sender, PaintEventArgs e)
        {
            pbLoading.Visible = true;
            fetchArticlesBackgroundWorker.RunWorkerAsync();
        }
    }
}
