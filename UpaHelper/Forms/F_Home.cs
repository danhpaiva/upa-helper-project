using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpaHelper
{
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
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
    }
}
