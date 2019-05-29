using BusinessLogicLayer.ViewModels;
using CustomControlLibrary.Entities;
using Entities;
using System.Collections.Generic;
using System.Configuration;

namespace BusinessLogicLayer
{
    public static class Converter
    {
        public static ArticlePreviewModel FromArticleShortToArticlePreviewModel(ArticleShort articleShort)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            return new ArticlePreviewModel {
                Id = articleShort.Id,
                Title = articleShort.Title,
                ImageUrl = string.Format("{0}/{1}/{2}", contentPath, articleShort.Id, articleShort.TitleImageName),
                HasDocument = articleShort.HasDocument,
                HasVideo = articleShort.HasVideo,
                CategoryName = articleShort.ContentCategory.Name
            };
        }

        public static List<ArticlePreviewModel> FromArticleShortCollectionToArticlePreviewModelCollection(List<ArticleShort> articleShortCollection)
        {
            var articlePreviewModelCollection = new List<ArticlePreviewModel>();

            foreach(var articleShort in articleShortCollection)
            {
                var articlePreviewModel = Converter.FromArticleShortToArticlePreviewModel(articleShort);
                articlePreviewModelCollection.Add(articlePreviewModel);
            }

            return articlePreviewModelCollection;

        }

        public static ImageBoxItem FromArticlePreviewModelToImageBoxItem(ArticlePreviewModel articlePreviewModel)
        {
            return new ImageBoxItem {
                Id = articlePreviewModel.Id,
                Title = articlePreviewModel.Title,
                ImageUrl = articlePreviewModel.ImageUrl,
                HasVideo = articlePreviewModel.HasVideo,
                HasDocuments = articlePreviewModel.HasDocument,
                Category = articlePreviewModel.CategoryName
            };
        }

        public static List<ImageBoxItem> FromArticlePreviewModelCollectionToImageBoxItemCollection(List<ArticlePreviewModel> articlePreviewModelCollection)
        {
            var imageBoxItemCollection = new List<ImageBoxItem>();

            foreach (var articlePreviewModel in articlePreviewModelCollection)
            {
                var imageBoxItem = Converter.FromArticlePreviewModelToImageBoxItem(articlePreviewModel);
                imageBoxItemCollection.Add(imageBoxItem);
            }

            return imageBoxItemCollection;
        }

        public static ArticleModel FromArticleToArticleModel(Article article)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            return new ArticleModel
            {
                Id = article.Id,
                Title = article.Title,
                ImageUrl = string.Format("{0}/{1}/{2}", contentPath, article.Id, article.TitleImageName),
                HasDocument = article.HasDocument,
                HasVideo = article.HasVideo,
                CategoryName = article.ContentCategory.Name,
                Content = article.Content,
            };
        }

        public static ContentCategoryViewModel FromContentCategoryToContentCategoryViewModel(ContentCategory contentCategory)
        {
            return new ContentCategoryViewModel {
                Id = contentCategory.Id,
                Name = contentCategory.Name,
            };
        }

        public static List<ContentCategoryViewModel> FromContentCategoryCollectionToContentCategoryViewModelCollection(List<ContentCategory> contentCategories)
        {
            var contentCategoryViewModelCollection = new List<ContentCategoryViewModel>();

            foreach(var contentCategory in contentCategories)
            {
                var contentCatetoryViewModel = FromContentCategoryToContentCategoryViewModel(contentCategory);
                contentCategoryViewModelCollection.Add(contentCatetoryViewModel);

            }

            return contentCategoryViewModelCollection;
        }

        public static ContentCategory FromContentCategoryViewModelToContentCategory(ContentCategoryViewModel contentCategoryViewModel)
        {
            return new ContentCategory
            {
                Id = contentCategoryViewModel.Id,
                Name = contentCategoryViewModel.Name,
            };
        }
    }
}
