using Entities;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Interfaces
{
    public interface IArticleRepository
    {
        List<ArticleShort> GetLatestArticles(int limit = 0);

        List<ArticleShort> GetArticlesByCategoryId(int contentCategoryId, int limit = 0);

        Article GetArticleById(Guid articleId);

        List<ArticleShort> SearchArticlesByTitle(string keyword, bool isPublished = true);

        List<ArticleShort> SearchArticlesByContent(string keyword, bool isPublished = true);

        List<ArticleShort> GetArticles();

    }
}
