using Entities;
using MySql.Data.MySqlClient;
using System;

namespace DatabaseLayer
{
    public static class Converter
    {
        public static User FromMySqlDataReaderToUser(MySqlDataReader rdr)
        {
            var user = new User();

            user.Id = Guid.Parse((string)rdr[0]);
            user.Name = (string)rdr[1];
            user.Password = (string)rdr[2];
            user.UserType = (UserType)(int)rdr[3];

            return user;
        }
    }
}
