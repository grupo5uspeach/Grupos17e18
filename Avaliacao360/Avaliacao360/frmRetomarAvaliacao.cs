﻿using System;
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
    public partial class frmRetomarAvaliacao : Form
    {
        public frmRetomarAvaliacao()
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
            Form Iniciar = new frmIniciarAvaliacao();
            Iniciar.Closed += (s, args) => this.Close();
            Iniciar.Show();
        }
    }
}
