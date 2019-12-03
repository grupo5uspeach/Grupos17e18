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
    public partial class frmTelaImpressao : Form
    {
        public frmTelaImpressao()
        {
            InitializeComponent();
        }

        private void frmTelaImpressao_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Funcionário 1");
            comboBox1.Items.Add("Funcionário 2");
            comboBox1.Items.Add("Funcionário 3");
            comboBox1.Items.Add("Funcionário 4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form EscolheUsuario = new frmEscolhaFuncionario();
            EscolheUsuario.Closed += (s, args) => this.Close();
            EscolheUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmImprimir().Show();
        }
    }
}
