using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao360
{
    public partial class frmColaborativo1 : Form
    {
        public frmColaborativo1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCancelar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Colaborativo2 = new frmColaborativo2();
            Colaborativo2.Closed += (s, args) => this.Close();
            Colaborativo2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmSalvar().Show();
        }
    }
}
