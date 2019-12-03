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
    public partial class frmIniciarAvaliacao : Form
    {
        public frmIniciarAvaliacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmDescartar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Tecnico1 = new frmTecnico1();
            Tecnico1.Closed += (s, args) => this.Close();
            Tecnico1.Show();
        }
    }
}
