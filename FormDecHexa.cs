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
    public partial class FormDecHexa : Form
    {
        public FormDecHexa()
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
                    int primeiraDiv = valorOriginal % 16;
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
                    valorOriDec = valorOriDec / 16;
                    valorOriginal = valorOriDec % 16;
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
            for (int j = 0; j < 30; j++)
            {

                if (vetorDecimal[j] == 10)
                {
                    mostra = mostra + "A";
                    

                }
                if (vetorDecimal[j] == 11)
                {
                    mostra = mostra + "B";
                }
                if (vetorDecimal[j] == 12)
                {
                    mostra = mostra + "C";
                }
                if (vetorDecimal[j] == 13)
                {
                    mostra = mostra + "D";
                }
                if (vetorDecimal[j] == 14)
                {
                    mostra = mostra + "E";
                }
                if (vetorDecimal[j] == 15)
                {
                    mostra = mostra + "F";
                }
                if (vetorDecimal[j] < 10)
                {
                    mostra = mostra + vetorDecimal[j];
                }

            }
            lblBInario.Text = mostra.ToString();
            //   int VetorDecimal = new int 
        }
    }

    

}


