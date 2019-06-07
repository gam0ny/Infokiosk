using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Repositories;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BusinessLogicLayer
{
    public class Controller : IController
    {
        private readonly IContentCategoryRepository contentCategoryRepository;
        private readonly IArticleRepository articleRepository;
        private readonly IUserRepository userRepository;
        public Controller()
        {
            contentCategoryRepository = new ContentCategoryRepository();
            articleRepository = new ArticleRepository();
            userRepository = new UserRepository();
        }

        public List<ArticlePreviewModel> GetLatestArticles(int limit = 0)
        {
            var dbArticles = articleRepository.GetLatestArticles(limit);

            return Converter.FromArticleShortCollectionToArticlePreviewModelCollection(dbArticles);
        }

        public List<ArticlesByCategoryPreviewModel> GetArticlesByCategories(bool includeEmptyCategories = false)
        {
            var articlesByCategoryPreviewModelCollection = new List<ArticlesByCategoryPreviewModel>();

            var contentCategories = contentCategoryRepository.GetContentCategories();

            foreach (var contentCategory in contentCategories)
            {
                var articlesByCategoryPreviewModel = new ArticlesByCategoryPreviewModel();
                articlesByCategoryPreviewModel.Category = contentCategory.Name;

                var articlesCollection = articleRepository.GetArticlesByCategoryId(contentCategory.Id);

                articlesByCategoryPreviewModel.Articles = Converter.FromArticleShortCollectionToArticlePreviewModelCollection(articlesCollection);

                if(articlesByCategoryPreviewModel.Articles.Count > 0 || (articlesByCategoryPreviewModel.Articles.Count == 0 && includeEmptyCategories))
                {
                    articlesByCategoryPreviewModelCollection.Add(articlesByCategoryPreviewModel);
                }

            }
            return articlesByCategoryPreviewModelCollection;
        }

        public ArticleModel GetArticleById(Guid articleId)
        {
            var dbArticle = articleRepository.GetArticleById(articleId);
            var articleModel = Converter.FromArticleToArticleModel(dbArticle);

            articleModel.Content = FixImageUrls(articleModel.Content, articleId);

            return articleModel;
        }

        public List<ArticlePreviewModel> SearchArticlesByTitle(string keyword)
        {
            var dbArticles = articleRepository.SearchArticlesByTitle(keyword);

            return Converter.FromArticleShortCollectionToArticlePreviewModelCollection(dbArticles);
        }

        public List<ArticlePreviewModel> SearchArticlesByContent(string keyword)
        {
            var dbArticles = articleRepository.SearchArticlesByContent(keyword);

            return Converter.FromArticleShortCollectionToArticlePreviewModelCollection(dbArticles);
        }

        public void SendEmail(string toEmail, ArticleModel article, SendCompletedEventHandler Client_SendCompleted)
        {
            var corporateEmail = ConfigurationManager.AppSettings["CorporateEmail"];
            var corporateLogin = ConfigurationManager.AppSettings["CorporateLogin"];
            var corporatePassword = ConfigurationManager.AppSettings["CorporatePassword"];
            var corporateEmailHost = ConfigurationManager.AppSettings["CorporateEmailHost"];
            var corporateMailTimeout = ConfigurationManager.AppSettings["CorporateMailTimeout"];

            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(corporateLogin, corporatePassword);
            client.Host = corporateEmailHost;
            client.Timeout = Convert.ToInt32(corporateMailTimeout);
            client.SendCompleted += Client_SendCompleted;

            MailMessage mail = new MailMessage(corporateEmail, toEmail);
            mail.Subject = article.Title;
            mail.IsBodyHtml = true;
            string updatedContent;
            var attachments = CreateAttachmentCollection(article, out updatedContent);
            mail.Body = updatedContent;

            foreach (var attachment in attachments)
            {
                mail.Attachments.Add(attachment);
            }

            client.SendMailAsync(mail);
        }

        private List<Attachment> CreateAttachmentCollection(ArticleModel article, out string updatedContent)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];
            var attachments = new List<Attachment>();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(article.Content);
            var imageTags = doc.DocumentNode.SelectNodes("//img");

            foreach (var imageTag in imageTags)
            {
                string imageTagValue = imageTag.Attributes["src"].Value;

                var attachmnetPath = string.Format("{0}{1}/{2}", contentPath, article.Id, imageTagValue);

                if (File.Exists(attachmnetPath))
                {
                    var attachment = new Attachment(attachmnetPath);

                    attachment.ContentId = imageTagValue;

                    imageTag.SetAttributeValue("src", string.Format("cid:{0}", imageTagValue));
                    attachments.Add(attachment);
                }
            }

            updatedContent = doc.DocumentNode.InnerHtml;

            return attachments;
        }

        public bool EmailIsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool Authenticate(string login, string password, out Guid? userId)
        {
            var result = userRepository.Authenticate(login, password, out userId);

            return result;
        }

        public List<ContentCategoryViewModel> GetContentCategories()
        {
            return Converter.FromContentCategoryCollectionToContentCategoryViewModelCollection(contentCategoryRepository.GetContentCategories());
        }

        public bool AddContentCategory(ContentCategoryViewModel contentCategoryViewModel)
        {
            return contentCategoryRepository.Add(Converter.FromContentCategoryViewModelToContentCategory(contentCategoryViewModel));
        }

        public bool EditContentCategory(ContentCategoryViewModel contentCategoryViewModel)
        {
            return contentCategoryRepository.Edit(Converter.FromContentCategoryViewModelToContentCategory(contentCategoryViewModel));
        }

        public bool DeleteContentCategory(ContentCategoryViewModel contentCategoryViewModel)
        {
            return contentCategoryRepository.Delete(Converter.FromContentCategoryViewModelToContentCategory(contentCategoryViewModel));
        }

        public List<ArticlePreviewModel> GetArticles()
        {
            return Converter.FromArticleShortCollectionToArticlePreviewModelCollection(articleRepository.GetArticles());
        }

        public bool DeleteArticle(ArticlePreviewModel articlePreviewModel)
        {
            return articleRepository.Delete(Converter.FromArticlePreviewModelToArticleShort(articlePreviewModel));
        }

        public bool SaveArticle(ArticleModel articleModel)
        {
            var articleDirectory = string.Empty;

            if (articleModel.Id == Guid.Empty)
            {
                articleModel.Id = Guid.NewGuid();

                articleDirectory = CreateFolderStrucure(articleModel);
            }

            if (articleModel.ImageUrl != null && articleModel.TitleFileName != null)
            {
                File.Copy(articleModel.ImageUrl, string.Format("{0}/{1}", articleDirectory, articleModel.TitleFileName));
            }

            articleModel.HasVideo = articleModel.Content.Contains("<video>");

            return articleRepository.Save(Converter.FromArticleModelToArticle(articleModel));
        }

        private string CreateFolderStrucure(ArticleModel articleModel)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            var articleDirectory = string.Format("{0}{1}", contentPath, articleModel.Id);

            Directory.CreateDirectory(articleDirectory);

            return articleDirectory;
        }

        public string ExtractHtmlBody(string htmlDocument)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlDocument);
            var bodyNode = doc.DocumentNode.SelectSingleNode("//body");

            return bodyNode.InnerHtml;
        }

        public string FixImageUrls(string htmlString, Guid articleId)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var imageTags = doc.DocumentNode.SelectNodes("//img");

            if(imageTags != null)
            {
                foreach (var imageTag in imageTags)
                {
                    string imageTagValue = imageTag.Attributes["src"].Value;

                    imageTag.SetAttributeValue("src", string.Format("{0}{1}\\{2}", contentPath, articleId.ToString(), imageTagValue));

                }
            }

            return doc.DocumentNode.InnerHtml;
        }
    }
}
