using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPA_HELPER.DAL;

namespace UPA_HELPER
{
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmdPaciente, cmdAtendimento;

            Conexao conexao = new Conexao(); //Estabelecendo conexao com o banco

            //Cadastrando no banco na tabela paciente
            string SqlPaciente = "INSERT INTO paciente (nome, cpf, sexo, dataNascimento, rua, bairro, cidade) values(@nome, @cpf, @sexo, @data, @rua, @bairro, @cidade)";

            //Inserindo dados no banco na tabela atendimento
            string SqlAtendimento = "INSERT INTO atendimento (IdUPA, IdEspecializacao, descriçãoProblema, dataAtendimento, cpf) values(@upa, @especializacao, @descricao, @dataAtend, @cpf)";

            //Iniciando coleta de dados para a tabela paciente
            cmdPaciente = new SqlCommand(); //Para utilizar comandos SQL dentro do C#

            cmdPaciente.Parameters.AddWithValue("@nome", txt_nome.Text);
            cmdPaciente.Parameters.AddWithValue("@cpf", txt_cpf.Text);

            if (cb_sexo.SelectedIndex == (0))
            {
                cmdPaciente.Parameters.AddWithValue("@sexo", "F");
            }
            else
            {
                cmdPaciente.Parameters.AddWithValue("@sexo", "M");
            }

            cmdPaciente.Parameters.AddWithValue("@data", dt_datanascimento.Value);
            cmdPaciente.Parameters.AddWithValue("@rua", txt_rua.Text);
            cmdPaciente.Parameters.AddWithValue("@bairro", txt_bairro.Text);
            cmdPaciente.Parameters.AddWithValue("@cidade", cb_cidade.SelectedItem.ToString());

            //Iniciando coleta de dados para a tabela atendimento
            cmdAtendimento = new SqlCommand();

            cmdAtendimento.Parameters.AddWithValue("@upa", cb_upa.SelectedIndex + 1); //Somando 1 para pegar o índice do banco de dados
            cmdAtendimento.Parameters.AddWithValue("@especializacao", cb_medico.SelectedIndex + 1);
            cmdAtendimento.Parameters.AddWithValue("@descricao", rtb_descricao.Text);

            // Get the current date.
            DateTime thisDay = DateTime.Today;

            cmdAtendimento.Parameters.AddWithValue("@dataAtend", thisDay.ToString());
            cmdAtendimento.Parameters.AddWithValue("@cpf", txt_cpf.Text);

            try
            {
                /* c.Connection = conexao.Conectar();
                c.ExecuteNonQuery();
                conexao.Desconectar(); */
                conexao.ExecutarSQL(cmdPaciente, SqlPaciente);
                conexao.ExecutarSQL(cmdAtendimento, SqlAtendimento);

                MessageBox.Show("SUCESSO!!", "Sucesso");

                LimparCampos(); //Limpar campos após cadastro
            }
            catch (SqlException ex)
            {
                string msg;

                msg = "ERRO: " + ex.Message;

                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close(); // Fecha a janela atual
        }

        private void cb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_cpf_Click(object sender, EventArgs e)
        {
            //Ativando o botão de Atualizar
            btn_atualizar_cpf.Show();
            //Ativando o botão de Cadastrar
            btn_cadastrar.Show();

            SqlCommand cmd = new SqlCommand(); //Comando para trabalhar com SQL dentro do VS
            cmd.CommandText = "SELECT * from paciente WHERE CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text);

            Conexao conexao = new Conexao();
            SqlDataReader dr;

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //Desativando o botão cadastrar
                    btn_cadastrar.Hide();

                    MessageBox.Show("Usuário encontrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dr.Read();

                    txt_nome.Text = dr[1].ToString(); //Pegando o índice 1 do banco e armazenando no txt_nome

                    //Condição para pegar o sexo da pessoa do banco de dados
                    if (dr[3].Equals("M"))
                    {
                        cb_sexo.SelectedIndex = 1;
                    }
                    else if (dr[3].Equals("F"))
                    {
                        cb_sexo.SelectedIndex = 0;
                    }

                    txt_rua.Text = dr[5].ToString(); //Pegando o índice 5 do banco e armazenando no txt_rua
                    txt_bairro.Text = dr[6].ToString(); //Pegando o índice 6 do banco e armazenando no txt_bairro

                    //Condição para pegar a cidade da pessoa do banco de dados
                    switch (dr[7].ToString())
                    {
                        case "Belo Horizonte":
                            cb_cidade.SelectedIndex = 0;
                            break;

                        case "Betim":
                            cb_cidade.SelectedIndex = 1;
                            break;

                        case "Contagem":
		                    cb_cidade.SelectedIndex = 2;
                            break;

                        case "Ribeirão das Neves":
		                    cb_cidade.SelectedIndex = 3;
                            break;

                        case "Sabará":
                            cb_cidade.SelectedIndex = 4;
                            break;

                        case "Sete Lagoas":
                            cb_cidade.SelectedIndex = 5;
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("CPF não encontrado, preencha o cadastro do paciente!", "Cadastre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Desativar botão de atualizar
                    btn_atualizar_cpf.Hide();
                }
            }
            catch (SqlException)
            {

            }
        }

        private void btn_atualizar_cpf_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAtendimento;

            Conexao conexao = new Conexao(); //Estabelecendo conexao com o banco

            //Inserindo dados no banco na tabela atendimento
            string SqlAtendimento = "INSERT INTO atendimento (IdUPA, IdEspecializacao, descriçãoProblema, dataAtendimento, cpf) values(@upa, @especializacao, @descricao, @dataAtend, @cpf)";

            //Iniciando coleta de dados para a tabela atendimento
            cmdAtendimento = new SqlCommand();

            cmdAtendimento.Parameters.AddWithValue("@upa", cb_upa.SelectedIndex + 1); //Somando 1 para pegar o índice do banco de dados
            cmdAtendimento.Parameters.AddWithValue("@especializacao", cb_medico.SelectedIndex + 1);
            cmdAtendimento.Parameters.AddWithValue("@descricao", rtb_descricao.Text);

            // Get the current date.
            DateTime thisDay = DateTime.Today;

            cmdAtendimento.Parameters.AddWithValue("@dataAtend", thisDay.ToString());
            cmdAtendimento.Parameters.AddWithValue("@cpf", txt_cpf.Text);

            try
            {
                conexao.ExecutarSQL(cmdAtendimento, SqlAtendimento);
                MessageBox.Show("SUCESSO!!", "Sucesso");
                LimparCampos();
            }
            catch (SqlException ex)
            {
                string msg;

                msg = "ERRO: " + ex.Message;

                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparCampos()
        {
            txt_cpf.Text = ""; //Limpar campo que já esteja com dados
            txt_nome.Text = "";
            cb_sexo.SelectedIndex = -1;
            txt_rua.Text = "";
            txt_bairro.Text = "";
            cb_cidade.SelectedIndex = -1;
            cb_upa.SelectedIndex = -1;
            cb_medico.SelectedIndex = -1;
            rtb_descricao.Text = "";
        }

        private void btn_limpar_dados_Click(object sender, EventArgs e)
        {
            LimparCampos(); //Limpa os campos preenchidos da tela
        }
    }
}
