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
    public partial class frmEscolhaFuncionario : Form
    {
        public frmEscolhaFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEscolhaFuncionario_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Funcionario 1");
            comboBox1.Items.Add("Funcionario 2");
            comboBox1.Items.Add("Funcionario 3");
            comboBox1.Items.Add("Funcionario 4");
            comboBox1.Items.Add("Funcionario 5");
            comboBox1.Items.Add("Funcionario 6");
            comboBox1.Items.Add("Funcionario 7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCancelar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Retomar = new frmRetomarAvaliacao();
            Retomar.Closed += (s, args) => this.Close();
            Retomar.Show();
        }
    }
}
