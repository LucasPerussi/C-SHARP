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
    public partial class FormSomaBinarios : Form
    {
        public FormSomaBinarios()
        {
            InitializeComponent();

        }

      
        string[] vetorbit1 = new string[4];
        string[] vetorbit2 = new string[4];
        string[] vetorMostra = new string[5];
        string bit1;
        string bit2;

        int contaPrimeiro = 0;
        int carry;
        int carry2;
        string Mostrar = " ";
        int verificaCarry = 0;

        private void btSomar_Click(object sender, EventArgs e)
        {

            lblMostrar.Text = " ";
            Mostrar = " ";
            bit1 = tbBit1.Text;
            bit2 = tbBit2.Text;

            for (int c = 0; c < 4; c++) //Monta Vetor
            {
                vetorbit1[c] = bit1[c].ToString();
                vetorbit2[c] = bit2[c].ToString();
             
            }
            
            for (int i = 5; i > -1; i--)
            {

                if (i - 2 >= 0)
                {


                    if (contaPrimeiro == 0)
                    {

                        /////////////////////      AND     ///////////////////////////////////
                        if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "0"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "0"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "1"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "1"))
                        {
                            carry = 1;
                        }
                        //////////////////////      XOR    ////////////////////////////////
                        if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "0"))
                        {
                            vetorMostra[i - 1] = "0";
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "0"))
                        {
                            vetorMostra[i - 1] = "1";
                        }
                        else if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "1"))
                        {
                            vetorMostra[i - 1] = "1";
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "1"))
                        {
                            vetorMostra[i - 1] = "0";
                        }

                        contaPrimeiro = 1;

                    }
                    else
                    {   
                       
                        //////////////////////   VALIDO   XOR    ////////////////////////////////
                        if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "0"))
                        {
                            carry2 = 0;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "0"))
                        {
                            carry2 = 1;
                        }
                        else if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "1"))
                        {
                            carry2 = 1;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "1"))
                        {
                            carry2 = 0;
                        }
                        //////////////////////   VALIDO   XOR CARRY2 E 1   ////////////////////////////////
                        if ((carry2 == 0) && (carry == 0))
                        {
                            vetorMostra[i - 1] = "0";
                        }
                        else if ((carry2 == 1) && (carry == 0))
                        {
                            vetorMostra[i - 1] = "1";
                        }
                        else if ((carry2 == 0) && (carry == 1))
                        {
                            vetorMostra[i - 1] = "1";
                        }
                        else if ((carry2 == 1) && (carry == 1))
                        {
                            vetorMostra[i - 1] = "0";
                        }
                        /////////////////////   VALIDO AND CARRY 2 E 1     ///////////////////////////////////
                        if ((carry2 == 0) && (carry == 0))
                        {
                            carry2 = 0;
                        }
                        else if ((carry2 == 1) && (carry == 0))
                        {
                            carry2 = 0;
                        }
                        else if ((carry2 == 0) && (carry == 1))
                        {
                            carry2 = 0;
                        }
                        else if ((carry2 == 1) && (carry == 1))
                        {
                            carry2 = 1;
                        }
                        //////////////////////   VALIDO  AND BITS ORIGINAIS E MANDO PRO CARRY   ////////////////////////////////
                        if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "0"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "0"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "0") && (vetorbit2[i - 2] == "1"))
                        {
                            carry = 0;
                        }
                        else if ((vetorbit1[i - 2] == "1") && (vetorbit2[i - 2] == "1"))
                        {
                            carry = 1;
                        }
                        /////////////////////   VALIDO OR CARRY 2 E 1     ///////////////////////////////////
                        if ((carry2 == 0) && (carry == 0))
                        {
                            carry = 0;
                        }
                        else if ((carry2 == 1) && (carry == 0))
                        {
                            carry = 1;
                        }
                        else if ((carry2 == 0) && (carry == 1))
                        {
                            carry = 1;
                        }
                        else if ((carry2 == 1) && (carry == 1))
                        {
                            carry = 1;
                        }


                    }
                }
            }

            if (carry == 1)
            {
                vetorMostra[0] = "1";
            }
            if (vetorMostra[0] == null)
            {
                vetorMostra[0] = "0";
            }


            for (int v = 0; v < 5; v++)
            {
                Mostrar = Mostrar + vetorMostra[v];
            }

            tbResultado.Text = Mostrar.TrimStart();
          

        }

        private void OperacaoAND(int contador, int carry, string[] Vetor1, string[] Vetor2)
        {

              
           

        }

        private void operacaoXOR()
        {

        }

        private void operacaoOR()
        {

        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }

        private void tbBit1_Leave(object sender, EventArgs e)
        {
            string binario = tbBit1.Text;
            string[] binarioVetor = new string[binario.Length]; //{ binario.Split };
            int contador = binario.Length;
            int final = 1;
            int total = 0;
            int tamanho = binario.Length;

            for (int c = 0; c < contador; c++) //Monta Vetor
            {
                binarioVetor[c] = binario[c].ToString();
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
                        final = final * 2;
                    }
                }

                final = final * ponto;
                total = total + final;

            }

            tbDec1.Text = total.ToString();
        }

        private void tbBit2_Leave(object sender, EventArgs e)
        {
            string binario = tbBit2.Text;
            string[] binarioVetor = new string[binario.Length]; //{ binario.Split };
            int contador = binario.Length;
            int final = 1;
            int total = 0;
            int tamanho = binario.Length;

            for (int c = 0; c < contador; c++) //Monta Vetor
            {
                binarioVetor[c] = binario[c].ToString();
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
                        final = final * 2;
                    }
                }

                final = final * ponto;
                total = total + final;
            }

            tbDec2.Text = total.ToString();
        }

        private void DecimalResultado()
        {
            
        }


        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

            string binario = tbResultado.Text;
            string[] binarioVetor = new string[binario.Length]; //{ binario.Split };
            int contador = binario.Length;
            int final = 1;
            int total = 0;
            int tamanho = binario.Length;

            for (int c = 0; c < contador; c++) //Monta Vetor
            {
                binarioVetor[c] = binario[c].ToString();
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
                        final = final * 2;
                    }
                }

                final = final * ponto;
                total = total + final;
            }

            tbDec3.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSomador soma = new FormSomador();
            soma.Show();
        }
    }
}
