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
    public partial class frmColaborativo4 : Form
    {
        public frmColaborativo4()
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
            Form Colaborativo5 = new frmColaborativo5();
            Colaborativo5.Closed += (s, args) => this.Close();
            Colaborativo5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmSalvar().Show();
        }
    }
}
