using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_HELPER.DAL
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-GSM9DDC\SQLEXPRESS;Initial Catalog=UPA_HELPER;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void ExecutarSQL(SqlCommand c, string SQL)
        {
            con.Open();
            c.Connection = con;
            c.CommandText = SQL;
            c.ExecuteNonQuery();
            // c.ExecuteScalar();
            con.Close();
        }
    }
}
