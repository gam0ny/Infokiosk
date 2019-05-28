using BusinessLogicLayer.ViewModels;
using System.Collections.Generic;

namespace BusinessLogicLayer.Interfaces
{
    public interface IInfokioskAdministrationDesktopApplicationController
    {
        bool Authenticate(string login, string password);

        List<ContentCategoryViewModel> GetContentCategories();

        bool AddContentCategory(ContentCategoryViewModel contentCategoryViewModel);
    }
}
