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
    public partial class frmCorporativo1 : Form
    {
        public frmCorporativo1()
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
            Form Corporativo2 = new frmCorporativo2();
            Corporativo2.Closed += (s, args) => this.Close();
            Corporativo2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmSalvar().Show();
        }
    }
}
