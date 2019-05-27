using BusinessLogicLayer.Interfaces;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Repositories;

namespace BusinessLogicLayer
{
    public class InfokioskAdministrationDesktopApplicationController : IInfokioskAdministrationDesktopApplicationController
    {
        private IUserRepository userRepository;

        public InfokioskAdministrationDesktopApplicationController()
        {
            userRepository = new UserRepository();
        }
        public bool Authenticate(string login, string password)
        {
            return userRepository.Authenticate(login, password);
        }
    }
}
