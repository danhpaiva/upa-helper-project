﻿using System.Data.SqlClient;

namespace UpaHelperUser.DataBase
{
    class Connection
    {
        SqlConnection conn = new SqlConnection();

        public Connection()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-GSM9DDC\SQL_SERVER;Initial Catalog=UPA_HELPER;Integrated Security=True";
        }

        public SqlConnection Connect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        public void Disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

