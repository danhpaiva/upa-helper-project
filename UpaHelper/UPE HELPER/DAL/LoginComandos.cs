using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UPA_HELPER.DAL
{
    class LoginComandos
    {
        public bool tem = false;
        public string mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao conexao = new Conexao();

        SqlDataReader dr; //Criação do leitor do SQL

        public bool VerificarLogin(string login, string senha, ref string fotoFunc)
        {

            cmd.CommandText = "SELECT fotoFunc from funcionario WHERE loginFunc = @login AND senha = @senha";

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                    dr.Read();
                    fotoFunc = dr[0].ToString();
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return tem;
        }
    }
}
