using Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class ContentCategoryRepository : BaseRepository
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
    }
}
