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
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

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


        private int beforeUpdateScrollPosition = 0;

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
                if (contentCategory.Id == articleModel.CategoryId)
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

            var fixedHtmlContent = controller.FixImageUrlsBeforeShow(this.articleModel.Content, this.articleModel.Id);

            this.rtbxContent.Text = controller.ExtractHtmlBody(fixedHtmlContent);

            highlighter.FindAndHighlight(this.rtbxContent, 0, this.rtbxContent.TextLength);

            this.cbxIsPublish.Checked = this.articleModel.IsPublishing;
        }

        private void SaveArticleInProgress(object sender, DoWorkEventArgs e)
        {
            var articleModel = (ArticleModel)e.Argument;
            articleModel.Content = controller.FixImageUrlsBeforeSave(articleModel.Content, articleModel.Id);
            e.Result = controller.SaveArticle(articleModel);
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
            webBrowser1.Document.Window.ScrollTo(new Point(0, beforeUpdateScrollPosition));
        }

        private void RtbxContent_TextChanged(object sender, EventArgs e)
        {
            articleModel.Content = string.Format("{0}{1}{2}", tbxHeader.Text, rtbxContent.Text, tbxFooter.Text);

            if (this.webBrowser1.Document != null)
            {
                var document = (System.Windows.Forms.HtmlDocument)webBrowser1.Document;
                var elements = document.GetElementsByTagName("HTML");
                if (elements.Count > 0)
                {
                    beforeUpdateScrollPosition = elements[0].ScrollTop;
                }
            }

            if (webBrowser1.Document == null ||
                webBrowser1.Document.Body != null &&
                webBrowser1.DocumentText != articleModel.Content)
            {
                webBrowser1.DocumentText = articleModel.Content;
            }
        }

        private void BtnH1_Click(object sender, EventArgs e)
        {
            var manageBasicTagForm = new ManageBasicTagForm();
            manageBasicTagForm.TagName = "h1";
            manageBasicTagForm.TagText = rtbxContent.SelectedText;
            var dialogResult = manageBasicTagForm.ShowDialog();
            
            if (dialogResult == DialogResult.OK)
            {
                rtbxContent.SelectedText = manageBasicTagForm.ResultHtml;
                highlighter.FindAndHighlight(rtbxContent, rtbxContent.SelectionStart, manageBasicTagForm.ResultHtml.Length);
            }
        }

        private void SetupBasicTagAndInsert(string tagName)
        {
            var manageBasicTagForm = new ManageBasicTagForm();
            manageBasicTagForm.TagName = tagName;
            manageBasicTagForm.TagText = rtbxContent.SelectedText;
            var dialogResult = manageBasicTagForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                rtbxContent.SelectedText = manageBasicTagForm.ResultHtml;
                highlighter.FindAndHighlight(rtbxContent, rtbxContent.SelectionStart, manageBasicTagForm.ResultHtml.Length);
            }
        }

        private void BtnH2_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("h2");
        }

        private void BtnH3_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("h3");
        }

        private void BtnH4_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("h4");
        }

        private void BtnH5_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("h5");
        }

        private void BtnH6_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("h6");
        }

        private void RtbxContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                int selectionStart = rtbxContent.SelectionStart;
                Regex rx = new Regex(@"<.*?", RegexOptions.RightToLeft);
                Match match = rx.Match(rtbxContent.Text, selectionStart);
                if (match.Success)
                    highlighter.FindAndHighlight(rtbxContent, match.Index, match.Length);
                rtbxContent.Select(selectionStart, 0);
                rtbxContent.SelectionColor = Color.Black;

                rx = new Regex(@"&.*?", RegexOptions.RightToLeft);
                match = rx.Match(rtbxContent.Text, selectionStart);
                if (match.Success)
                {
                    rtbxContent.Select(match.Index, match.Length);
                    rtbxContent.SelectionColor = Color.Black;
                    highlighter.FindAndHighlight(rtbxContent, match.Index, match.Length);
                }
                rtbxContent.Select(selectionStart, 0);
                rtbxContent.SelectionColor = Color.Black;
            }
            if (e.KeyChar == '\b')
            {

                int selectionStart = rtbxContent.SelectionStart;
                Regex rx = new Regex(@"<.*?", RegexOptions.RightToLeft);
                Match match = rx.Match(rtbxContent.Text, selectionStart);
                if (match.Success)
                {
                    rtbxContent.Select(match.Index, match.Length);
                    rtbxContent.SelectionColor = Color.Black;
                    highlighter.FindAndHighlight(rtbxContent, match.Index, match.Length);
                }
                rtbxContent.Select(selectionStart, 0);
                rtbxContent.SelectionColor = Color.Black;
            }
        }

        private void BtnBR_Click(object sender, EventArgs e)
        {
            var html = "<br>";
            rtbxContent.SelectedText = html;
            highlighter.FindAndHighlight(rtbxContent, rtbxContent.SelectionStart, html.Length);
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("i");
        }

        private void BtnStrong_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("strong");
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            SetupBasicTagAndInsert("p");
        }
    }
}
