using Entities;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        bool Authenticate(string username, string password, out Guid? userId);
    }
}
