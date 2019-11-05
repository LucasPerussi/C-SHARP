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
    public partial class FormDecBinario : Form
    {
        public FormDecBinario()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int dec = Convert.ToInt32(tbDec.Text);
            int[] vetorDecimal = new int[30];
            int valorOriginal = dec;
            int valorOriDec = dec;
            int cont = 0;
            int cont2 = 0;
            string mostra = " ";

            for (int i = 30; i > -1; i--)
            {

                if (cont2 == 0)
                {
                    int primeiraDiv = valorOriginal % 2;
                    if (valorOriDec < 2)
                    {
                        if (cont2 < 1)
                        {
                            vetorDecimal[i - 1] = 1;
                            cont = 2;
                        }
                    }
                    vetorDecimal[i - 1] = primeiraDiv;
                    cont2 = 2;
                }
                else
                {
                    valorOriDec = valorOriDec / 2;
                    valorOriginal = valorOriDec % 2;
                    if (valorOriDec < 2)
                    {
                        if (cont2 < 1)
                        {
                            vetorDecimal[i - 1] = 1;
                            cont = 2;
                        }
                    }
                    if (i >= 1)
                    {
                        vetorDecimal[i - 1] = valorOriginal;
                    }
                }
            }
            for (int j = 0; j <30; j++)
            {
                mostra = mostra + vetorDecimal[j];
               
            }

           
            lblBInario.Text = mostra.ToString();
         //   int VetorDecimal = new int 
        }

        private void tbDec_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decimal_Click(object sender, EventArgs e)
        {

        }
    }

}
