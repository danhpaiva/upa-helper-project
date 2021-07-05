using System;
using System.Windows.Forms;

namespace UpaHelper
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            F_Home f_Home = new F_Home();
            f_Home.Show();
        }
    }
}
