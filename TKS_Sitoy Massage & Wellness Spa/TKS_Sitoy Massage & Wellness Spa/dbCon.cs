using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace TKS_Sitoy_Massage___Wellness_Spa
{
    internal class dbCon
    {
        private string connString = "server=localhost;database=massage_system_db;uid=root;pwd=;";

        public MySqlConnection connection;

        public dbCon()
        {
            connection = new MySqlConnection(connString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

    }
}
