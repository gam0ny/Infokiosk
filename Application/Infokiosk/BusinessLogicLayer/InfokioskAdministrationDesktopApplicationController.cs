using System.Collections.Generic;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.ViewModels;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Repositories;

namespace BusinessLogicLayer
{
    public class InfokioskAdministrationDesktopApplicationController : IInfokioskAdministrationDesktopApplicationController
    {
        private IUserRepository userRepository;

        private IContentCategoryRepository contentCategoryRepository;

        public InfokioskAdministrationDesktopApplicationController()
        {
            userRepository = new UserRepository();
            contentCategoryRepository = new ContentCategoryRepository();
        }
        public bool Authenticate(string login, string password)
        {
            return userRepository.Authenticate(login, password);
        }

        public List<ContentCategoryViewModel> GetContentCategories()
        {
            return Converter.FromContentCategoryCollectionToContentCategoryViewModelCollection(contentCategoryRepository.GetContentCategories());
        }
    }
}
