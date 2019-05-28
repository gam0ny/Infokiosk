using Entities;
using System.Collections.Generic;

namespace DatabaseLayer.Interfaces
{
    public interface IContentCategoryRepository
    {

        List<ContentCategory> GetContentCategories(bool newestToOldest = false);

        ContentCategory GetContentCategoryById(int id);

        bool Add(ContentCategory contentCategory);

        bool Edit(ContentCategory contentCategory);

        bool Delete(ContentCategory contentCategory);

    }
}
