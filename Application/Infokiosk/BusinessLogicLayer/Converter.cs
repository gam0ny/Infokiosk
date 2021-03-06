﻿using BusinessLogicLayer.ViewModels;
using CustomControlLibrary.Entities;
using Entities;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace BusinessLogicLayer
{
    public static class Converter
    {
        public static ArticlePreviewModel FromArticleShortToArticlePreviewModel(ArticleShort articleShort)
        {
            var contentPath = ConfigurationManager.AppSettings["ContentPath"];

            return new ArticlePreviewModel
            {
                Id = articleShort.Id,
                Title = articleShort.Title,
                ImageUrl = string.Format("{0}{1}\\{2}", contentPath, articleShort.Id, articleShort.TitleImageName),
                HasDocument = articleShort.HasDocument,
                HasVideo = articleShort.HasVideo,
                CategoryId = articleShort.ContentCategory.Id,
                CategoryName = articleShort.ContentCategory.Name,
            };
        }

        public static List<ArticlePreviewModel> FromArticleShortCollectionToArticlePreviewModelCollection(List<ArticleShort> articleShortCollection)
        {
            var articlePreviewModelCollection = new List<ArticlePreviewModel>();

            foreach (var articleShort in articleShortCollection)
            {
                var articlePreviewModel = Converter.FromArticleShortToArticlePreviewModel(articleShort);
                articlePreviewModelCollection.Add(articlePreviewModel);
            }

            return articlePreviewModelCollection;

        }

        public static ImageBoxItem FromArticlePreviewModelToImageBoxItem(ArticlePreviewModel articlePreviewModel)
        {
            return new ImageBoxItem
            {
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
                ImageUrl = string.Format("{0}{1}\\{2}", contentPath, article.Id, article.TitleImageName),
                HasDocument = article.HasDocument,
                HasVideo = article.HasVideo,
                CategoryId = article.ContentCategory.Id,
                CategoryName = article.ContentCategory.Name,
                Content = article.Content,
                IsPublishing = article.IsPublished,
                UserId = article.UserId,
                TitleFileName = article.TitleImageName,
            };
        }

        public static Article FromArticleModelToArticle(ArticleModel articleModel)
        {
            return new Article
            {
                Content = articleModel.Content,
                ContentCategory = new ContentCategory { Id = articleModel.CategoryId, Name = articleModel.CategoryName },
                Id = articleModel.Id,
                Title = articleModel.Title,
                HasDocument = articleModel.HasDocument,
                HasVideo = articleModel.HasVideo,
                TitleImageName = articleModel.TitleFileName,
                IsPublished = articleModel.IsPublishing,
                UserId = articleModel.UserId
            };
        }

        public static ContentCategoryViewModel FromContentCategoryToContentCategoryViewModel(ContentCategory contentCategory)
        {
            return new ContentCategoryViewModel
            {
                Id = contentCategory.Id,
                Name = contentCategory.Name,
            };
        }

        public static List<ContentCategoryViewModel> FromContentCategoryCollectionToContentCategoryViewModelCollection(List<ContentCategory> contentCategories)
        {
            var contentCategoryViewModelCollection = new List<ContentCategoryViewModel>();

            foreach (var contentCategory in contentCategories)
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

        public static ArticleShort FromArticlePreviewModelToArticleShort(ArticlePreviewModel articlePreviewModel)
        {
            return new ArticleShort
            {
                Id = articlePreviewModel.Id,
                ContentCategory = new ContentCategory { Id= articlePreviewModel.CategoryId, Name = articlePreviewModel.CategoryName },
                HasDocument = articlePreviewModel.HasDocument,
                HasVideo = articlePreviewModel.HasVideo,
                Title = articlePreviewModel.Title,
                TitleImageName = Path.GetFileName(articlePreviewModel.ImageUrl),
            };
        }
    }
}
