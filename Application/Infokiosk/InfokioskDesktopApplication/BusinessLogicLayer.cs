using DatabaseLayer.Repositories;
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
    }
}
