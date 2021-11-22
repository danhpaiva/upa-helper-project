using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UPA_HELPER;
using UPA_HELPER.DAL;
using UPA_HELPER.Formularios;

namespace UPE_HELPER
{
    public partial class TelaUPA : Form
    {
        public TelaUPA()
        {
            InitializeComponent();
        }

        public string fotoFunc, IdUPA;

        private void TelaUPA_Load(object sender, EventArgs e)
        {
            ConsultarPaciente(); //Chamando o método para saber quantos pacientes estão na UPA

            pic_func.Load(fotoFunc);

            //////////////////////////////////////
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT nome FROM funcionario WHERE fotoFunc = @foto";

            comando.Parameters.AddWithValue("@foto", fotoFunc.ToString());

            Conexao conexao = new Conexao(); //Instanciou objeto Conexao

            SqlDataReader dr;

            try
            {
                comando.Connection = conexao.Conectar();
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    lbl_loginAtual.Text = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Login não encontrado!");
                }
            }
            catch (SqlException)
            {

            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastroPaciente cadastroPaciente = new CadastroPaciente();
            cadastroPaciente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // Fechar a janela atual
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_concluirAtend_Click(object sender, EventArgs e)
        {
            ConcluirAtendimento concluir = new ConcluirAtendimento();
            concluir.Show();
        }

        private void btn_tel_Click(object sender, EventArgs e)
        {
            TelefoneUtil novaTela = new TelefoneUtil(); //Instanciando form
            novaTela.Show(); //Chamando
        }

        private void lbl_relogio_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2003, 5, 1); //Instanciando objeto

            lbl_data.Text = DateTime.Now.ToString("dd") + " DE " + DateTime.Now.ToString("MMMM").ToUpper();
            lbl_ano.Text = DateTime.Now.ToString("yyyy");
            //lbl_ano.Text = year.ToString();
           

            // lbl_dia.Text = day + ” de ” +mes + “\n  ” +year;
            lbl_relogio.Text = DateTime.Now.ToString("HH:mm:ss"); //Setando o relogio na label

        }

        private void btn_covid_Click(object sender, EventArgs e)
        {
            Covid covidTela = new Covid();
            covidTela.Show();
        }

        private void lbl_dia_Click(object sender, EventArgs e)
        {
            //Não apague
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Não apague
        }

        public void ConsultarPaciente()
        {
            Conexao conexao = new Conexao(); //Abrindo conexao com o banco

            SqlCommand cmd = new SqlCommand(); //Manipulando comando SQL dentro do VS

            SqlDataReader dr;

            cmd.CommandText = "SELECT COUNT (statusAtendimento) FROM atendimento WHERE statusAtendimento = 1 AND IdUPA = @upa";

            cmd.Parameters.AddWithValue("@upa", BuscarUpaLocal());

            try
            {
                cmd.Connection = conexao.Conectar(); //Abre o comando para enviar os comandos
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read(); //Lendo o que retornou do banco de dados

                    lbl_contadorUPA.Text = dr[0].ToString(); //Armazenando as quantidades de pacientes da UPA local
                }
            }
            catch (SqlException)
            {

            }
        }

        //Função para pegar a UPA do usuário logado no sistema
        public string BuscarUpaLocal()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT IdUPA FROM funcionario WHERE fotoFunc = @foto";

            comando.Parameters.AddWithValue("@foto", fotoFunc.ToString());

            Conexao conexao = new Conexao(); //Instanciou objeto Conexao

            SqlDataReader dr;

            try
            {
                comando.Connection = conexao.Conectar();
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    IdUPA = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Login não encontrado!");
                }
            }
            catch (SqlException)
            {

            }

            return IdUPA;
        }
    }
}