using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UpaHelperUser.DataBase;
using UpaHelperUser.Forms;

namespace UpaHelperUser
{
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tel_Click(object sender, EventArgs e)
        {
            F_Telephone f_Telephone = new F_Telephone();
            f_Telephone.Show();
        }

        private void btn_covid_Click(object sender, EventArgs e)
        {
            F_Covid f_Covid = new F_Covid();
            f_Covid.Show();
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            F_Dev f_Dev = new F_Dev();
            f_Dev.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();

            SqlCommand cmdAddPacienteContador = new SqlCommand(); //Instanciando o contador de todos os pacientes da UPA
            SqlCommand cmdPegarEndUPA = new SqlCommand();

            SqlDataReader leitorContador, leitorEndereco; //Leitor de informações SQL

            cmdAddPacienteContador.CommandText = "SELECT COUNT(statusAtendimento) FROM atendimento WHERE statusAtendimento = 1 AND IdUPA = @upa";
            cmdPegarEndUPA.CommandText = "SELECT rua, numero, bairro FROM upa WHERE IdUPA = @upa";

            cmdAddPacienteContador.Parameters.AddWithValue("@upa", cb_listUPA.SelectedIndex + 1); //Somando 1 para igualar com o índice do banco de dados
            cmdPegarEndUPA.Parameters.AddWithValue("@upa", cb_listUPA.SelectedIndex + 1);

            try
            {
                cmdAddPacienteContador.Connection = conn.Conectar();
                leitorContador = cmdAddPacienteContador.ExecuteReader();

                if (leitorContador.HasRows)
                {
                    leitorContador.Read(); //Ler mais linhas


                    lbl_qtdPeople.Text = leitorContador[0].ToString() + " paciente(s)"; //Armazenando na label o total de pacientes da tabela

                }

                conn.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Consulte o administrador do sistema.", "Erro!");
            }

            try
            {
                cmdPegarEndUPA.Connection = conn.Conectar();
                leitorEndereco = cmdPegarEndUPA.ExecuteReader();

                if (leitorEndereco.HasRows)
                {
                    leitorEndereco.Read();
                    lbl_adress.Text = leitorEndereco[0].ToString() + ", " + leitorEndereco[1].ToString() + "\n" + leitorEndereco[2].ToString(); //Pegar os 3 campos do endereço da linha
                }

                conn.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Consulte o administrador do sistema.", "Erro!");
            }
        }
    }
}
