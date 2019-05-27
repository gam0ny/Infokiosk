using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace DatabaseLayer
{
    public class DatabaseManager : IDisposable
    {
        public string ConnectionString { get; set; }

        public MySqlConnection MySqlConnection { get; set; }

        public DatabaseManager()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["Infokiosk"].ConnectionString;
            MySqlConnection = new MySqlConnection(ConnectionString);
        }

        public MySqlDataReader Execute(string sql)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, MySqlConnection);

            return cmd.ExecuteReader();
        }

        public MySqlDataReader Execute(string sql, DatabaseParameter[] parameters)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, MySqlConnection);

            foreach(var parameter in parameters)
            {
                cmd.Parameters.Add(new MySqlParameter(parameter.Name, parameter.Value));
            }

            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            MySqlConnection.Close();
        }
    }
}
