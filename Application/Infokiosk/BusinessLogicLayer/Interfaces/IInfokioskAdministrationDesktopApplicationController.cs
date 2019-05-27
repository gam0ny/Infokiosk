namespace BusinessLogicLayer.Interfaces
{
    public interface IInfokioskAdministrationDesktopApplicationController
    {
        bool Authenticate(string login, string password);
    }
}
