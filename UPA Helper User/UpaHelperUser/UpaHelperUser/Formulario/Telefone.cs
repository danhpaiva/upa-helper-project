using System;
using System.Windows.Forms;

namespace UpaHelperUser
{
    public partial class Telefone : Form
    {
        public Telefone()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close(); //Fechar tela atual
        }

        private void Telefone_Load(object sender, EventArgs e)
        {

        }
    }
}
