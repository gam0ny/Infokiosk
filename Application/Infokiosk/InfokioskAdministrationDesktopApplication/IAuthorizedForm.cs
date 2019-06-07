using System;

namespace InfokioskAdministrationDesktopApplication
{
    public interface IAuthorizedForm
    {
        Guid? UserId { get; set; }
    }
}
