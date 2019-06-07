using BusinessLogicLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace BusinessLogicLayer.Interfaces
{
    public interface IController
    {
        List<ArticlePreviewModel> GetLatestArticles(int limit = 0);

        List<ArticlesByCategoryPreviewModel> GetArticlesByCategories(bool includeEmptyCategories = false);

        ArticleModel GetArticleById(System.Guid articleId);

        List<ArticlePreviewModel> SearchArticlesByTitle(string keyword);

        List<ArticlePreviewModel> SearchArticlesByContent(string keyword);

        void SendEmail(string toEmail, ArticleModel article, SendCompletedEventHandler Client_SendCompleted);

        bool EmailIsValid(string emailAddress);

        bool Authenticate(string login, string password, out Guid? userId);

        List<ContentCategoryViewModel> GetContentCategories();

        bool AddContentCategory(ContentCategoryViewModel contentCategoryViewModel);

        bool EditContentCategory(ContentCategoryViewModel contentCategoryViewModel);

        bool DeleteContentCategory(ContentCategoryViewModel contentCategoryViewModel);

        List<ArticlePreviewModel> GetArticles();

        bool SaveArticle(ArticleModel articleModel);

        bool DeleteArticle(ArticlePreviewModel articlePreviewModel);
    }
}
