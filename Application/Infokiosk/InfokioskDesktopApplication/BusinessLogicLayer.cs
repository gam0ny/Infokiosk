using DatabaseLayer.Repositories;
using InfokioskDesktopApplication.Models;
using System;
using System.Collections.Generic;

namespace InfokioskDesktopApplication
{
    public class BusinessLogicLayer
    {
        private readonly ContentCategoryRepository contentCategoryRepoitory;
        private readonly ArticleRepository articleRepository;
        public BusinessLogicLayer()
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
    }
}
