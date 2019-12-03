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
    public partial class frmCorporativo3 : Form
    {
        public frmCorporativo3()
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
            Form Corporativo4 = new frmCorporativo4();
            Corporativo4.Closed += (s, args) => this.Close();
            Corporativo4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmSalvar().Show();
        }
    }
}
