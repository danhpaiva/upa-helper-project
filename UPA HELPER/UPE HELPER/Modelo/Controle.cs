using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_HELPER.Modelo
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool Acessar(string login, string senha, ref string fotoFunc)
        {
            DAL.LoginComandos loginCom = new DAL.LoginComandos();

            tem = loginCom.VerificarLogin(login, senha, ref fotoFunc);

            if (!loginCom.mensagem.Equals(""))
            {
                this.mensagem = loginCom.mensagem;
            }
            return tem;
        }
    }
}
