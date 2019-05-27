using BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Mail;

namespace BusinessLogicLayer.Interfaces
{
    public interface IInfokioskDesktopApplicationController
    {
        List<ArticlePreviewModel> GetLatestArticles(int limit = 0);

        List<ArticlesByCategoryPreviewModel> GetArticlesByCategories();

        ArticleModel GetArticleById(System.Guid articleId);

        List<ArticlePreviewModel> SearchArticlesByTitle(string keyword);

        List<ArticlePreviewModel> SearchArticlesByContent(string keyword);

        void SendEmail(string toEmail, ArticleModel article, SendCompletedEventHandler Client_SendCompleted);
    }
}
