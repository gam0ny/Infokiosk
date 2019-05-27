using Entities;
using Interfaces;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class ContentCategoryRepository : BaseRepository, IContentCategoryRepository
    {
        public List<ContentCategory> GetContentCategories()
        {
            var sqlStatement = "SELECT Id, Name FROM ContentCategory";

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
            var sqlStatement = "SELECT Id, Name FROM ContentCategory WHERE Id = @id";

            MySqlDataReader rdr = DbManager.Execute(sqlStatement,
                new Parameter[] { new Parameter() { Name = "@id", Value = id.ToString() } });

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
    }
}
