using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpaHelperUser.DAL
{
    class Comandos
    {
        Conexao conect = new Conexao();
        SqlCommand c = new SqlCommand();

        SqlDataReader dr; //Criação do leitor do SQL

        public void BuscarDados()
        {
            c.CommandText = "SELECT fotoFunc from funcionario WHERE loginFunc = @login AND senha = @senha";
        }
    }
}
