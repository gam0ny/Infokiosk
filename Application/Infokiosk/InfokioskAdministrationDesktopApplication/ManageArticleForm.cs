using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageArticleForm : Form
    {
        private ManageArticlesForm manageArticlesForm;

        private ArticleModel articleModel;

        private BackgroundWorker getContentCategoriesBackgroundWorker;

        private IController controller;

        private string localPreviewImagePath;
        public ManageArticleForm()
        {
            InitializeComponent();
            articleModel = new ArticleModel();

            this.getContentCategoriesBackgroundWorker = new BackgroundWorker();
            this.getContentCategoriesBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingContentCategoriesInProgress);
            this.getContentCategoriesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingContentCategoriesComplete);

            this.controller = new Controller();
        }

        public ManageArticleForm(ManageArticlesForm manageArticlesForm) : this()
        {
            this.manageArticlesForm = manageArticlesForm;
        }

        private void FetchingContentCategoriesInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.GetContentCategories();
        }

        private void FetchingContentCategoriesComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            var contentCategories = (List<ContentCategoryViewModel>)e.Result;
            cbCategories.Items.Clear();
            foreach (var contentCategory in contentCategories)
            {
                cbCategories.ValueMember = "Id";
                cbCategories.DisplayMember = "Name";
                cbCategories.Items.Add(contentCategory);
            }
        }
        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            manageArticlesForm.Show();
            this.Close();
        }

        private void TableLayoutPanelPreviewControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxTitle_TextChanged(object sender, EventArgs e)
        {
            var value = ((TextBox)sender).Text;
            articleModel.Title = value;
            ibArticlePreview.Title = articleModel.Title;
        }

        private void BtnFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    localPreviewImagePath = fileName;
                    ibArticlePreview.Image = Image.FromFile(localPreviewImagePath);
                    tbxFileUpload.Text = localPreviewImagePath;
                }
            }
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (ContentCategoryViewModel)cbCategories.SelectedItem;

            this.articleModel.CategoryName = selectedCategory.Name;

            this.ibArticlePreview.Category = selectedCategory.Name;
        }

        private void ManageArticleForm_Paint(object sender, PaintEventArgs e)
        {
            //init default data
            ibArticlePreview.Category = "Категория";
            ibArticlePreview.Title = "Название";
            ibArticlePreview.Image = Image.FromFile(ConfigurationManager.AppSettings["NoFileImagePath"]);
        }

        private void ManageArticleForm_Load(object sender, EventArgs e)
        {
            getContentCategoriesBackgroundWorker.RunWorkerAsync();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отменить редактирование статьи? Все внесенные изменения НЕ будут сохранены", "Внимание!", MessageBoxButtons.YesNo);

            if (result.ToString().ToUpper() == "Yes".ToUpper())
            {
                manageArticlesForm.Show();
                this.Close();
            }
        }

        private void CbxIsPublish_CheckedChanged(object sender, EventArgs e)
        {
            articleModel.IsPublishing = ((CheckBox)sender).Checked;
        }
    }
}
