using DatabaseLayer.Interfaces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public List<User> GetUsers()
        {
            MySqlDataReader rdr = DbManager.Execute("SELECT * FROM user");

            var users = new List<User>();

            while (rdr.Read())
            {
                var user = Converter.FromMySqlDataReaderToUser(rdr);
                users.Add(user);
            }
            rdr.Close();

            return users;
        }

        public bool Authenticate(string username, string password, out Guid? userId)
        {
            var isAuthenticated = false;

            userId = null;

            MySqlDataReader rdr = DbManager.Execute(
                "SELECT * FROM user WHERE name = @name AND password = @password", 
                new DatabaseParameter[] { new DatabaseParameter() { Name = "@name", Value = username }, new DatabaseParameter() { Name = "@password", Value = password } });

            if(rdr.HasRows)
            {
                isAuthenticated = true;

                while (rdr.Read())
                {
                    Guid result;
                    if (Guid.TryParse((string)rdr[0], out result))
                    {
                        userId = result;
                    }
                }

            }

            return isAuthenticated;
        }
    }
}
