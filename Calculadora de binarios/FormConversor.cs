using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitetura_de_Computadores_UFPR
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void FormConversor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBinDec call = new FormBinDec();
            call.ShowDialog();
        }

        private void btBinHexa_Click(object sender, EventArgs e)
        {
            FormBinHexa hex = new FormBinHexa();
            hex.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDecBinario debi = new FormDecBinario();
            debi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDecHexa decex = new FormDecHexa();
            decex.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHexDec hexdec = new FormHexDec();
            hexdec.ShowDialog();
        }
    }
}
