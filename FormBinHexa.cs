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
    public partial class FormBinHexa : Form
    {
        public FormBinHexa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            converteBinHex();
        }
        private void converteBinHex()
        {
            string binario = tbBin.Text;

            string[] binarioVetor = new string[4]; //{ binario.Split };
            int contador = binario.Length;
            int tamanho = binario.Length;

            for (int c = 0; c < 4; c++) //Monta Vetor
            {
                binarioVetor[c] = binario[c].ToString();
            }


           if (binarioVetor[1 + 2 + 3 + 4] == "0001")
           {
               lblHexa.Text += 1;
           }
           else if (binarioVetor[1 + 2 + 3 + 4] == "0010")
           {
                lblHexa.Text += 2;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "0011"))
           {
                lblHexa.Text += 3;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "0100"))
           {
                lblHexa.Text += 4;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "0101"))
           {
                lblHexa.Text += 5;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "0110"))
           {
                lblHexa.Text += 6;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "0111"))
           {
                lblHexa.Text += 7;
           }
           if((binarioVetor[1 + 2 + 3 + 4] == "1000"))
           {
                lblHexa.Text += 8;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "1001"))
           {
                lblHexa.Text += 9;
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "1010"))
           {
                lblHexa.Text += "A";
           }
           if((binarioVetor[1 + 2 + 3 + 4] == "1011"))
           {
                lblHexa.Text += "B";
           }
           if ((binarioVetor[1 + 2 + 3 + 4] == "1100"))
           {
                lblHexa.Text += "C";
           }
           if((binarioVetor[1 + 2 + 3 + 4] == "1101"))
           {
                lblHexa.Text += "D";
           }
           if((binarioVetor[1 + 2 + 3 + 4] == "1110"))
           {
                lblHexa.Text += "E";
           }
           if((binarioVetor[1 + 2 + 3 + 4] == "1111"))
           {
                lblHexa.Text += "F";
           }
        }

    }
}
