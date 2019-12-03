using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao360
{
    public partial class frmPopupSalvar : Form
    {
        public frmPopupSalvar()
        {
            InitializeComponent();
        }

        private void frmPopupSalvar_Shown(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPopupSalvar_Load(object sender, EventArgs e)
        {

        }

        private void frmPopupSalvar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
