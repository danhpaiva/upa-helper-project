using System;
using System.Windows.Forms;
using UPA_HELPER.Modelo;

namespace UPE_HELPER
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }
        private void tela_login_Load(object sender, EventArgs e)
        {

        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); // Fecha a janela atual
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();

            string fotoFunc = "";
            controle.Acessar(txtLogin.Text, txtSenha.Text, ref fotoFunc);

            if (controle.mensagem.Equals(""))
            {
                
                if (controle.tem)
                {
                    TelaUPA novaTela = new TelaUPA();

                    novaTela.fotoFunc = fotoFunc;
                    novaTela.Show();

                    txtLogin.Text = ""; //Após o login bem sucessido o campo de texto é "limpado" para segurança do usuário
                    txtSenha.Text = ""; 
                } 
                else
                {
                    MessageBox.Show("Login não encontrado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }

        private void pnlLogin_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
    }
}

