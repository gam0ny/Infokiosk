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
using ComboBoxItem = System.Windows.Controls.ComboBoxItem;

namespace InfokioskAdministrationDesktopApplication
{
    public partial class ManageArticleForm : Form, IAuthorizedForm
    {
        private ManageArticlesForm manageArticlesForm;

        private ArticleModel articleModel;

        private BackgroundWorker getContentCategoriesBackgroundWorker;

        private BackgroundWorker saveArticleBackgroundWorker;

        private BackgroundWorker fetchArticleBackgroundWorker;

        private IController controller;

        private string localPreviewImagePath;

        private Highlighter highlighter;

        private Image noFileImage;

        public Guid? UserId { get; set; }

        public ManageArticleForm()
        {
            InitializeComponent();
            articleModel = new ArticleModel();

            this.getContentCategoriesBackgroundWorker = new BackgroundWorker();
            this.getContentCategoriesBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingContentCategoriesInProgress);
            this.getContentCategoriesBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingContentCategoriesComplete);

            this.saveArticleBackgroundWorker = new BackgroundWorker();
            this.saveArticleBackgroundWorker.DoWork += new DoWorkEventHandler(SaveArticleInProgress);
            this.saveArticleBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SaveArticleComplete);

            this.fetchArticleBackgroundWorker = new BackgroundWorker();
            this.fetchArticleBackgroundWorker.DoWork += new DoWorkEventHandler(FetchingArticleInProgress);
            this.fetchArticleBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FetchingArticleComplete);

            this.controller = new Controller();

            this.highlighter = new Highlighter();
        }

        public ManageArticleForm(ManageArticlesForm manageArticlesForm, Guid? articleId = null) : this()
        {
            this.manageArticlesForm = manageArticlesForm;
            this.UserId = manageArticlesForm.UserId;
            articleModel.UserId = this.UserId;
            articleModel.Id = articleId == null ? Guid.Empty : articleId.Value;
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

            if (articleModel.Id != Guid.Empty)
            {
                fetchArticleBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                articleModel.Content = string.Format("{0}{1}{2}", tbxHeader.Text, rtbxContent.Text, tbxFooter.Text);
            }
        }

        private void FetchingArticleInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.GetArticleById(this.articleModel.Id);
        }

        private void FetchingArticleComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.articleModel = (ArticleModel)e.Result;

            this.tbxTitle.Text = this.articleModel.Title;
            foreach (ContentCategoryViewModel contentCategory in cbCategories.Items)
            {
                if(contentCategory.Id == articleModel.CategoryId)
                {
                    cbCategories.SelectedItem = contentCategory;
                    break;
                }
            }

            this.cbCategories.SelectedItem = new ContentCategoryViewModel { Id = this.articleModel.CategoryId, Name = this.articleModel.CategoryName };
            this.tbxFileUpload.Text = this.articleModel.ImageUrl;
            this.cbxIsPublish.Checked = this.articleModel.IsPublishing;

            if (File.Exists(this.articleModel.ImageUrl))
            {
                this.ibArticlePreview.Image = Image.FromFile(this.articleModel.ImageUrl);
            }
            else
            {
                this.ibArticlePreview.Image = this.noFileImage;
            }

            this.rtbxContent.Text = controller.ExtractHtmlBody(this.articleModel.Content);

            this.rtbxContent.SelectAll();
            highlighter.FindAndHighlight(this.rtbxContent, 0, this.rtbxContent.TextLength);

            if (string.IsNullOrEmpty(this.rtbxContent.Text)) webBrowser1.DocumentText = this.articleModel.Content;
        }

        private void SaveArticleInProgress(object sender, DoWorkEventArgs e)
        {
            e.Result = controller.SaveArticle((ArticleModel)e.Argument);
        }

        private void SaveArticleComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = (bool)e.Result;

            if (result)
            {
                MessageBox.Show("Статья сохранена успешно!", "Удача!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("К сожалениею, статья не была сохранена. Повторите попытку или обратитесь к администратору", "Неудача :(", MessageBoxButtons.OK);
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
                    articleModel.ImageUrl = localPreviewImagePath;
                    articleModel.TitleFileName = Path.GetFileName(localPreviewImagePath);
                }
            }
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (ContentCategoryViewModel)cbCategories.SelectedItem;

            this.articleModel.CategoryName = selectedCategory.Name;
            this.articleModel.CategoryId = selectedCategory.Id;

            this.ibArticlePreview.Category = selectedCategory.Name;
        }

        private void ManageArticleForm_Paint(object sender, PaintEventArgs e)
        {
            //init default data
            ibArticlePreview.Category = "Категория";
            ibArticlePreview.Title = "Название";
            var noFileImagePath = ConfigurationManager.AppSettings["NoFileImagePath"];

            if (File.Exists(noFileImagePath))
            {
                this.noFileImage = Image.FromFile(noFileImagePath);
            }
            else
            {
                throw new FileNotFoundException("'NoFileImagePath' key in App.config is wrong");
            }
        }

        private void ManageArticleForm_Load(object sender, EventArgs e)
        {
            getContentCategoriesBackgroundWorker.RunWorkerAsync();
        }

        private void CbxIsPublish_CheckedChanged(object sender, EventArgs e)
        {
            articleModel.IsPublishing = ((CheckBox)sender).Checked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateModel())
            {
                if (articleModel.IsPublishing)
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите опубликовать статью? Статья станет доступна на инфопортале", "Внимание!", MessageBoxButtons.YesNo);

                    if (result.ToString().ToUpper() == "Yes".ToUpper())
                    {

                        saveArticleBackgroundWorker.RunWorkerAsync(this.articleModel);
                    }
                }
                else
                {
                    saveArticleBackgroundWorker.RunWorkerAsync(this.articleModel);
                }
            }
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

        private bool ValidateModel()
        {
            var invalidCount = 0;

            var validationMessage = "Следующие поля обязательны для заполнения: ";

            if (string.IsNullOrWhiteSpace(this.articleModel.Title))
            {
                validationMessage += "\n\"Название\"";
                invalidCount++;
            }

            if (this.articleModel.CategoryId == 0)
            {
                validationMessage += "\n\"Категория\"";
                invalidCount++;
            }

            if (string.IsNullOrWhiteSpace(this.articleModel.ImageUrl))
            {
                validationMessage += "\n\"Картинка\"";
                invalidCount++;
            }

            if (invalidCount > 0)
                MessageBox.Show(validationMessage);

            return invalidCount == 0;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Visible = true;
        }

        private void RtbxContent_TextChanged(object sender, EventArgs e)
        {
            articleModel.Content = string.Format("{0}{1}{2}", tbxHeader.Text, rtbxContent.Text, tbxFooter.Text);
            webBrowser1.DocumentText = articleModel.Content;
        }
    }
}
