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
    public partial class frmTermoAceite : Form
    {
        public frmTermoAceite()
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
            Form EscolhaFuncionario = new frmEscolhaFuncionario();
            EscolhaFuncionario.Closed += (s, args) => this.Close();
            EscolhaFuncionario.Show();
        }
    }
}
