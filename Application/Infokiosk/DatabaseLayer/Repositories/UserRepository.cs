using Entities;
using Interfaces;
using MySql.Data.MySqlClient;
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

        public bool Authenticate(string username, string password)
        {
            var isAuthenticated = false;

            MySqlDataReader rdr = DbManager.Execute(
                "SELECT * FROM user WHERE name = @name AND password = @password", 
                new Parameter[] { new Parameter() { Name = "@name", Value = username }, new Parameter() { Name = "@password", Value = password } });

            if(rdr.HasRows)
            {
                isAuthenticated = true;
            }

            return isAuthenticated;
        }
    }
}
