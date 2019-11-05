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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConversor conversor = new FormConversor();
            conversor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVerdade verd = new FormVerdade();
            verd.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSomaBinarios somador = new FormSomaBinarios();
            somador.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
