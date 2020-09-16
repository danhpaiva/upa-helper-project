using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UpaHelperUser.DAL;

namespace UpaHelperUser
{
    public partial class UpaHelperConsulta : Form
    {
        public UpaHelperConsulta()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            //O label nome da upa recebe o item selecionado no combobox
           // lbl_nome.Text = cb_nomeUPA.SelectedItem.ToString();

            Conexao conexao = new Conexao(); //Instanciando Conexao

            SqlCommand cmdAddPacienteContador = new SqlCommand(); //Instanciando o contador de todos os pacientes da UPA
            SqlCommand cmdPegarEndUPA = new SqlCommand();

            SqlDataReader leitorContador, leitorEndereco; //Leitor de informações SQL

            cmdAddPacienteContador.CommandText = "SELECT COUNT(statusAtendimento) FROM atendimento WHERE statusAtendimento = 1 AND IdUPA = @upa";
            cmdPegarEndUPA.CommandText = "SELECT rua, numero, bairro FROM upa WHERE IdUPA = @upa";

            cmdAddPacienteContador.Parameters.AddWithValue("@upa", cb_nomeUPA.SelectedIndex + 1); //Somando 1 para igualar com o índice do banco de dados
            cmdPegarEndUPA.Parameters.AddWithValue("@upa", cb_nomeUPA.SelectedIndex + 1);

            try
            {
                cmdAddPacienteContador.Connection = conexao.Conectar(); //Abrir Conexao
                leitorContador = cmdAddPacienteContador.ExecuteReader();

                if (leitorContador.HasRows)
                {
                    leitorContador.Read(); //Ler mais linhas
                   

                    lbl_qtdPaciente.Text = leitorContador[0].ToString() + " paciente(s)"; //Armazenando na label o total de pacientes da tabela
                   
                }

                conexao.Desconectar(); //Fechar Conexao
            }
            catch (SqlException)
            {
                MessageBox.Show("Consulte o administrador do sistema.", "Erro!");
            }

            try
            {
                cmdPegarEndUPA.Connection = conexao.Conectar(); //Abrir Conexão
                leitorEndereco = cmdPegarEndUPA.ExecuteReader();

                if (leitorEndereco.HasRows)
                {
                    leitorEndereco.Read();
                    lbl_enderecoUPA.Text = leitorEndereco[0].ToString() + ", " + leitorEndereco[1].ToString() + "\n" + leitorEndereco[2].ToString(); //Pegar os 3 campos do endereço da linha
                }

                conexao.Desconectar(); //Fechar Conexão
            }
            catch (SqlException)
            {
                MessageBox.Show("Consulte o administrador do sistema.", "Erro!");
            }
        }

        private void lbl_enderecoUPA_Click(object sender, EventArgs e)
        {

        }

        private void btn_telUtil_Click(object sender, EventArgs e)
        {
            Telefone novaTela = new Telefone();
            novaTela.Show(); //Abrir nova tela do formulário
        }

        private void bnt_covid_Click(object sender, EventArgs e)
        {
            Covid novaTela = new Covid();
            novaTela.Show(); //Abrir nova tela do formulário
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            DEV novaTela = new DEV();
            novaTela.Show(); //Abrir nova tela do formulário
        }

        private void UpaHelperConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
