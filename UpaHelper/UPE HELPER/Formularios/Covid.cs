using System;
using System.Windows.Forms;

namespace UPA_HELPER.Formularios
{
    public partial class Covid : Form
    {
        public Covid()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close(); //Fechar janela atual
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            /*Abre a caixa de impressão para selecionar impressora e se a pessoa der OK, entra no IF
            * printDialog1 é a ferramenta que abre a janela de opções de impressão*/

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDocument1 é o nome da ferramenta que executa os passos para a impressão
                printDocument1.PrinterSettings = printDialog1.PrinterSettings; //O print setting recebe as informações dadas no Dialog de impressão
                printDocument1.Print(); //Solicita impressão

                Close();
            }

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*Define o tipo de documento que será impresso
           (elemento a ser impresso, ponto de inicio na esquerda, ponto de inicio do topo, largura da impressão, altura da impressão)*/
            e.Graphics.DrawImage(pic_covid.Image, 0, 0, pic_covid.Width, pic_covid.Height);
        }

        private void pic_covid_Click(object sender, EventArgs e)
        {

        }
    }
}
