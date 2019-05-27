using Entities;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IContentCategoryRepository
    {

        List<ContentCategory> GetContentCategories();

        ContentCategory GetContentCategoryById(int id);

    }
}
