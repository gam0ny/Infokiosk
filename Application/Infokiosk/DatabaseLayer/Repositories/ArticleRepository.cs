using DatabaseLayer.Interfaces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class ArticleRepository : BaseRepository, IArticleRepository
    {
        public List<ArticleShort> GetLatestArticles(int limit = 0)
        {
            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name " +
                               "FROM Article t1 " +
                               "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
                               "WHERE t1.IsPublished = true " +
                               "ORDER BY t1.PublishingDate";

            if (limit > 0)
            {
                sqlStatement += string.Format(" LIMIT {0}", limit);
            }

            MySqlDataReader rdr = DbManager.Execute(sqlStatement);

            var articles = new List<ArticleShort>();

            while (rdr.Read())
            {
                var article = new ArticleShort
                {
                    Id = Guid.Parse((string)rdr[0]),
                    Title = (string)rdr[1],
                    TitleImageName = (string)rdr[2],
                    HasVideo = Convert.ToBoolean(rdr[3]),
                    HasDocument = Convert.ToBoolean(rdr[4]),
                    ContentCategory = new ContentCategory
                    {
                        Id = (int)rdr[5],
                        Name = (string)rdr[6],
                    }
                };
                articles.Add(article);
            }
            rdr.Close();

            return articles;
        }

        public List<ArticleShort> GetArticlesByCategoryId(int contentCategoryId, int limit = 0)
        {
            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name " +
                   "FROM Article t1 " +
                   "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
                   "WHERE t1.IsPublished = true AND t1.ContentCategoryId = @contentCategoryId " +
                   "ORDER BY t1.PublishingDate";

            if (limit > 0)
            {
                sqlStatement += string.Format(" LIMIT {0}", limit);
            }

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new DatabaseParameter[] { new DatabaseParameter() { Name = "@contentCategoryId", Value = contentCategoryId.ToString() } });

            var articles = new List<ArticleShort>();

            while (rdr.Read())
            {
                var article = new ArticleShort
                {
                    Id = Guid.Parse((string)rdr[0]),
                    Title = (string)rdr[1],
                    TitleImageName = (string)rdr[2],
                    HasVideo = Convert.ToBoolean(rdr[3]),
                    HasDocument = Convert.ToBoolean(rdr[4]),
                    ContentCategory = new ContentCategory
                    {
                        Id = (int)rdr[5],
                        Name = (string)rdr[6],
                    }
                };
                articles.Add(article);
            }
            rdr.Close();

            return articles;
        }

        public Article GetArticleById(Guid articleId)
        {
            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name, t1.Content, t1.UserId, t1.CreationDate, t1.EditDate " +
               "FROM Article t1 " +
               "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
               "WHERE t1.Id = @articleId";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new DatabaseParameter[] { new DatabaseParameter() { Name = "@articleId", Value = articleId.ToString() } });

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    return new Article
                    {
                        Id = Guid.Parse((string)rdr[0]),
                        Title = (string)rdr[1],
                        TitleImageName = (string)rdr[2],
                        HasVideo = Convert.ToBoolean(rdr[3]),
                        HasDocument = Convert.ToBoolean(rdr[4]),
                        ContentCategory = new ContentCategory
                        {
                            Id = (int)rdr[5],
                            Name = (string)rdr[6],
                        },
                        Content = (string)rdr[7],
                        UserId = Guid.Parse((string)rdr[8]),
                        CreationDate = (DateTime)rdr[9],
                        EditingDate = (DateTime)rdr[10],
                    };
                }
            }

            return null;

        }

        public List<ArticleShort> SearchArticlesByTitle(string keyword, bool isPublished = true)
        {
            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name " +
                   "FROM Article t1 " +
                   "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
                   "WHERE t1.IsPublished = @isPublished AND t1.Title LIKE @searchText " +
                   "ORDER BY t1.PublishingDate";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new DatabaseParameter[] {
                    new DatabaseParameter() { Name = "@searchText", Value = string.Format("%{0}%", keyword)},
                    new DatabaseParameter() { Name = "@isPublished", Value = Convert.ToInt32(isPublished).ToString() }
            });

            var articles = new List<ArticleShort>();

            while (rdr.Read())
            {
                var article = new ArticleShort
                {
                    Id = Guid.Parse((string)rdr[0]),
                    Title = (string)rdr[1],
                    TitleImageName = (string)rdr[2],
                    HasVideo = Convert.ToBoolean(rdr[3]),
                    HasDocument = Convert.ToBoolean(rdr[4]),
                    ContentCategory = new ContentCategory
                    {
                        Id = (int)rdr[5],
                        Name = (string)rdr[6],
                    }
                };
                articles.Add(article);
            }
            rdr.Close();

            return articles;
        }

        public List<ArticleShort> SearchArticlesByContent(string keyword, bool isPublished = true)
        {
            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name " +
                   "FROM Article t1 " +
                   "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
                   "WHERE t1.IsPublished = @isPublished AND t1.Content LIKE @searchText " +
                   "ORDER BY t1.PublishingDate";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new DatabaseParameter[] {
                    new DatabaseParameter() { Name = "@searchText", Value = string.Format("%{0}%", keyword)},
                    new DatabaseParameter() { Name = "@isPublished", Value = Convert.ToInt32(isPublished).ToString() }
                });

            var articles = new List<ArticleShort>();

            while (rdr.Read())
            {
                var article = new ArticleShort
                {
                    Id = Guid.Parse((string)rdr[0]),
                    Title = (string)rdr[1],
                    TitleImageName = (string)rdr[2],
                    HasVideo = Convert.ToBoolean(rdr[3]),
                    HasDocument = Convert.ToBoolean(rdr[4]),
                    ContentCategory = new ContentCategory
                    {
                        Id = (int)rdr[5],
                        Name = (string)rdr[6],
                    }
                };
                articles.Add(article);
            }
            rdr.Close();

            return articles;
        }

        public List<ArticleShort> GetArticles(bool incudeDeleted = false)
        {
            var articles = new List<ArticleShort>();

            var sqlStatement = "SELECT t1.Id, t1.Title, t1.TitleImageName, t1.HasVideo, t1.HasDocument, t2.Id, t2.Name " +
                               "FROM Article t1 " +
                               "INNER JOIN ContentCategory t2 ON t1.ContentCategoryId = t2.Id " +
                                string.Format("{0}", incudeDeleted == true ? string.Empty : "WHERE t1.IsDeleted = false ") +
                               "ORDER BY t1.PublishingDate";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement);

            while (rdr.Read())
            {
                var article = new ArticleShort
                {
                    Id = Guid.Parse((string)rdr[0]),
                    Title = (string)rdr[1],
                    TitleImageName = (string)rdr[2],
                    HasVideo = Convert.ToBoolean(rdr[3]),
                    HasDocument = Convert.ToBoolean(rdr[4]),
                    ContentCategory = new ContentCategory
                    {
                        Id = (int)rdr[5],
                        Name = (string)rdr[6],
                    }
                };
                articles.Add(article);
            }
            rdr.Close();

            return articles;

        }

        public bool Delete(ArticleShort articleShort)
        {
            var sqlStatement = "UPDATE Article SET IsDeleted = 1 WHERE Id = @articleId";
            bool result;
            try
            {
                MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                    new DatabaseParameter[] { new DatabaseParameter() { Name = "@articleId", Value = articleShort.Id.ToString() } });

                result = rdr.RecordsAffected > 0;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public bool Save(Article article)
        {
            var sqlStatement = "INSERT INTO Article (" +
                "Id" +
                ", Title" +
                ", TitleImageName" +
                ", Content" +
                ", HasVideo" +
                ", HasDocument" +
                ", ContentCategoryId" +
                ", UserId" +
                ", CreationDate" +
                ", EditDate" +
                ", IsPublished" +
                ", PublishingDate) " +
                "VALUES (" +
                "@articleId" +
                ", @articleTitle" +
                ", @articleTitleImageName" +
                ", @articleContent" +
                ", @articleHasVideo" +
                ", @articleHasDocument" +
                ", @articleContentCategoryId" +
                ", @articleUserId" +
                ", @articleCreationDate" +
                ", @articleEditDate" +
                ", @articleIsPublished" +
                ", @articlePublishingDate) ";

            bool result;
            try
            {
                DateTime timeStamp = DateTime.Now;

                MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                    new DatabaseParameter[] {
                        new DatabaseParameter() { Name = "@articleId", Value = article.Id.ToString() },
                        new DatabaseParameter() { Name = "@articleTitle", Value = article.Title },
                        new DatabaseParameter() { Name = "@articleTitleImageName", Value = article.TitleImageName },
                        new DatabaseParameter() { Name = "@articleContent", Value = article.Content },
                        new DatabaseParameter() { Name = "@articleHasVideo", Value = Convert.ToInt32(article.HasVideo).ToString() },
                        new DatabaseParameter() { Name = "@articleHasDocument", Value = Convert.ToInt32(article.HasDocument).ToString() },
                        new DatabaseParameter() { Name = "@articleContentCategoryId", Value = article.ContentCategory.Id.ToString() },
                        new DatabaseParameter() { Name = "@articleUserId", Value = article.UserId.ToString() },
                        new DatabaseParameter() { Name = "@articleCreationDate", Value = timeStamp.ToString("yyyy-MM-dd HH:mm:ss") },
                        new DatabaseParameter() { Name = "@articleEditDate", Value = timeStamp.ToString("yyyy-MM-dd HH:mm:ss") },
                        new DatabaseParameter() { Name = "@articleIsPublished", Value = Convert.ToInt32(article.IsPublished).ToString() },
                        new DatabaseParameter() { Name = "@articlePublishingDate", Value = article.IsPublished ? timeStamp.ToString("yyyy-MM-dd HH:mm:ss") : null},
                    });

                result = rdr.RecordsAffected > 0;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }
    }
}
