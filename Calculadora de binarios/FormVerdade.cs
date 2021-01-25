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
    public partial class FormVerdade : Form
    {
        public FormVerdade()
        {
            InitializeComponent();
        }

        private void comboBox1_DockChanged(object sender, EventArgs e)
        {
        
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            int bit1 = Convert.ToInt32(nudBit1.Value);
            int bit2 = Convert.ToInt32(nudBit2.Value);
            string falso = "0 (false)";
            string verdade = "1 (true)";

            if (comboBox1.Text == "E")
            {
                if ((bit1 == 0) && (bit2 == 0)){
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 0))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 0) && (bit2 == 1))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 1))
                {
                    lblResultado.Text = verdade.ToString();
                }
              
            }
            if (comboBox1.Text == "OU")
            {
                if ((bit1 == 0) && (bit2 == 0))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 0))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 0) && (bit2 == 1))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 1))
                {
                    lblResultado.Text = verdade.ToString();
                }

            }
            if (comboBox1.Text == "XOU")
            {
                if ((bit1 == 0) && (bit2 == 0))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 0))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 0) && (bit2 == 1))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 1))
                {
                    lblResultado.Text = falso.ToString();
                }

            }
            if (comboBox1.Text == "NAOE")
            {
                
                if ((bit1 == 0) && (bit2 == 0))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 0))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 0) && (bit2 == 1))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 1))
                {
                    lblResultado.Text = falso.ToString();
                }

            }
            if (comboBox1.Text == "NAOOU")
            {
                if ((bit1 == 0) && (bit2 == 0))
                {
                    lblResultado.Text = verdade.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 0))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 0) && (bit2 == 1))
                {
                    lblResultado.Text = falso.ToString();
                }
                else if ((bit1 == 1) && (bit2 == 1))
                {
                    lblResultado.Text = falso.ToString();
                }
            }
            if (comboBox1.Text == "NAO")
            {
                    if (bit1 == 0)
                    {
                        lblResultado.Text = verdade.ToString();
                    }
                    else if (bit1 == 1)
                    {
                        lblResultado.Text = falso.ToString();
                    }
            }

      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NAO")
            {
                nudBit2.Enabled = false;
            }
            else
            {
                nudBit2.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
