using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class ArticleRepository : BaseRepository
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
                new Parameter[] { new Parameter() { Name = "@contentCategoryId", Value = contentCategoryId.ToString() } });

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
                new Parameter[] { new Parameter() { Name = "@articleId", Value = articleId.ToString() } });

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
    }
}
