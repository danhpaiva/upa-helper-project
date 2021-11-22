using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPA_HELPER.DAL;

namespace UPA_HELPER
{
    public partial class ConcluirAtendimento : Form
    {
        string CpfConfirmado; //Variável para receber o cpf e dar baixar no paciente
        public ConcluirAtendimento()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(); //Comando para trabalhar com SQL dentro do VS
            cmd.CommandText = "SELECT * from paciente WHERE CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", btn_testecpf.Text);

            Conexao conexao = new Conexao();
            SqlDataReader dr;

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    lbl_nome.Text = dr[1].ToString();

                    CpfConfirmado = btn_testecpf.Text; //Armazenando CPF
                }
                else
                {
                    MessageBox.Show("CPF Não encontrado!");
                }
            }
            catch (SqlException)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_concluir_atd_Click(object sender, EventArgs e)
        {
            SqlCommand cmdConcluirAtendimento = new SqlCommand(); //Instanciando o objeto

            Conexao conexao = new Conexao(); // Estabelecendo conexao com o banco

            //Inserindo 0 na tabela Atendimento para dar baixa no paciente
            string SqlBaixaPaciente = "UPDATE atendimento SET statusAtendimento = 0 WHERE cpf = @cpf";

            cmdConcluirAtendimento.Parameters.AddWithValue("@cpf", CpfConfirmado);

            try
            {
                conexao.ExecutarSQL(cmdConcluirAtendimento, SqlBaixaPaciente); //Chamando objeto conexao com propriedade ExecutarSQL = conexao(cmd,sql)
                MessageBox.Show("Paciente liberado com sucesso!", "Sucesso");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao tentar liberar paciente. Consulte o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConcluirAtendimento_Load(object sender, EventArgs e)
        {

        }
    }
}
