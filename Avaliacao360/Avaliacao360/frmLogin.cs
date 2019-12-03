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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCancelar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TermoAceite = new frmTermoAceite();
            TermoAceite.Closed += (s, args) => this.Close();
            TermoAceite.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmEsqueciMinhaSenha().Show();
        }
    }
}
