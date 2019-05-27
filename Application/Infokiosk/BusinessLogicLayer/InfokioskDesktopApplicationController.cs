using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using DatabaseLayer.Repositories;
using HtmlAgilityPack;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BusinessLogicLayer
{
    public class InfokioskDesktopApplicationController : IInfokioskDesktopApplicationController
    {
        private readonly IContentCategoryRepository contentCategoryRepoitory;
        private readonly IArticleRepository articleRepository;
        public InfokioskDesktopApplicationController()
        {
            contentCategoryRepoitory = new ContentCategoryRepository();
            articleRepository = new ArticleRepository();
        }

        public List<ArticlePreviewModel> GetLatestArticles(int limit = 0)
        {
            var dbArticles = articleRepository.GetLatestArticles(limit);

            return Converter.FromArticleShortCollectionToArticlePreviewModelCollection(dbArticles);
        }

        public List<ArticlesByCategoryPreviewModel> GetArticlesByCategories()
        {
            var articlesByCategoryPreviewModelCollection = new List<ArticlesByCategoryPreviewModel>();

            var contentCategories = contentCategoryRepoitory.GetContentCategories();

            foreach (var contentCategory in contentCategories)
            {
                var articlesByCategoryPreviewModel = new ArticlesByCategoryPreviewModel();
                articlesByCategoryPreviewModel.Category = contentCategory.Name;

                var articlesCollection = articleRepository.GetArticlesByCategoryId(contentCategory.Id);

                articlesByCategoryPreviewModel.Articles = Converter.FromArticleShortCollectionToArticlePreviewModelCollection(articlesCollection);

                articlesByCategoryPreviewModelCollection.Add(articlesByCategoryPreviewModel);

            }
            return articlesByCategoryPreviewModelCollection;
        }

        public ArticleModel GetArticleById(Guid articleId)
        {
            var dbArticle = articleRepository.GetArticleById(articleId);

            return Converter.FromArticleToArticleModel(dbArticle);
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
    }
}
