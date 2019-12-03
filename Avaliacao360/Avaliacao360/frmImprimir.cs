using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao360
{
    public partial class frmImprimir : Form
    {
        public frmImprimir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string BinFolderPath = Environment.CurrentDirectory;
                string ProjectPath = Directory.GetParent(BinFolderPath).Parent.FullName;
                string PdfPath = @"" + ProjectPath + "/ExemploReport/Exemplo.pdf";
                System.Diagnostics.Process.Start(PdfPath);
                this.Close();
            }
            catch(Exception)
            {
                string PdfPath = Path.GetFullPath("ExemploReport/Exemplo.pdf");
                System.Diagnostics.Process.Start(PdfPath);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
