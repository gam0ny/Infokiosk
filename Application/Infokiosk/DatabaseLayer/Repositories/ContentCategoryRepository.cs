using DatabaseLayer.Interfaces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class ContentCategoryRepository : BaseRepository, IContentCategoryRepository
    {
        public List<ContentCategory> GetContentCategories(bool newestToOldest = false)
        {
            var sqlStatement = string.Format("SELECT Id, Name FROM ContentCategory WHERE IsDeleted = false ORDER BY Id {0}", newestToOldest ? "ASC" : "DESC");

            MySqlDataReader rdr = DbManager.Execute(sqlStatement);

            var contentCategories = new List<ContentCategory>();

            while (rdr.Read())
            {
                var contentCategory = new ContentCategory
                {
                    Id = (int)rdr[0],
                    Name = (string)rdr[1]
                };
                contentCategories.Add(contentCategory);
            }
            rdr.Close();

            return contentCategories;
        }

        public ContentCategory GetContentCategoryById(int id)
        {
            var sqlStatement = "SELECT Id, Name FROM ContentCategory WHERE Id = @id AND IsDeleted = false";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new DatabaseParameter[] { new DatabaseParameter() { Name = "@id", Value = id.ToString() } });

            ContentCategory contentCategory = null;

            while (rdr.Read())
            {
                contentCategory = new ContentCategory
                {
                    Id = (int)rdr[0],
                    Name = (string)rdr[1]
                };
            }
            rdr.Close();

            return contentCategory;
        }

        public bool Add(ContentCategory contentCategory)
        {
            var sqlStatement = "INSERT INTO ContentCategory (Name) VALUES (@contentCategoryName)";
            bool result;
            try
            {
                MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                    new DatabaseParameter[] { new DatabaseParameter() { Name = "@contentCategoryName", Value = contentCategory.Name } });

                result = rdr.RecordsAffected > 0;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public bool Delete(ContentCategory contentCategory)
        {
            var sqlStatement = "UPDATE ContentCategory SET IsDeleted = 1 WHERE Id = @contentCategoryId";
            bool result;
            try
            {
                MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                    new DatabaseParameter[] { new DatabaseParameter() { Name = "@contentCategoryId", Value = contentCategory.Id.ToString() } });

                result = rdr.RecordsAffected > 0;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;

        }

        public bool Edit(ContentCategory contentCategory)
        {
            var sqlStatement = "UPDATE ContentCategory SET Name = @contentCategoryName WHERE Id = @contentCategoryId";
            bool result;
            try
            {
                MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                    new DatabaseParameter[] {
                        new DatabaseParameter() { Name = "@contentCategoryId", Value = contentCategory.Id.ToString() },
                        new DatabaseParameter() { Name = "@contentCategoryName", Value = contentCategory.Name.ToString() }
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
