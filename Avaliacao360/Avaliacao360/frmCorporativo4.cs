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
    public partial class frmCorporativo4 : Form
    {
        public frmCorporativo4()
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
            Form Corporativo5 = new frmCorporativo5();
            Corporativo5.Closed += (s, args) => this.Close();
            Corporativo5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmSalvar().Show();
        }
    }
}
