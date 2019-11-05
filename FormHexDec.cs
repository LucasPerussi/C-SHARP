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
    public partial class FormHexDec : Form
    {
        public FormHexDec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binario = tbBin.Text;
            string[] binarioVetor = new string[binario.Length]; //{ binario.Split };
            int contador = binario.Length;
            int final = 1;
            int total = 0;
            int tamanho = binario.Length;

            for (int c = 0; c < contador; c++) //Monta Vetor
            {
                if (binario[c].ToString() == "A")
                {
                    binarioVetor[c] = 10.ToString();
                }
                else if (binario[c].ToString() == "B")
                {
                    binarioVetor[c] = 11.ToString();
                }
                else if (binario[c].ToString() == "C")
                {
                    binarioVetor[c] = 12.ToString();
                }
                else if (binario[c].ToString() == "D")
                {
                    binarioVetor[c] = 13.ToString();
                }
                else if (binario[c].ToString() == "E")
                {
                    binarioVetor[c] = 14.ToString();
                }
                else if (binario[c].ToString() == "F")
                {
                    binarioVetor[c] = 15.ToString();
                }
                else
                {
                    binarioVetor[c] = binario[c].ToString();
                }

            }

            for (int i = (contador - 1); i > -1; i--) //converte já invertido
            {
                int cont2 = contador - 1;
                final = 1;
                int localiza = ((tamanho - i) - 1);
                int ponto = Convert.ToInt32(binarioVetor[localiza]);

                if (ponto == 0)
                {
                    final = 0;
                }
                else
                {
                    for (int j = (i); j > 0; j--)
                    {
                        final = final * 16;
                    }
                }

                final = final * ponto;
                total = total + final;

            }

            lblBInario.Text = total.ToString();

        }
    }

}
