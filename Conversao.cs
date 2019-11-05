using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura_de_Computadores_UFPR
{
    class Conversao
    {
        public static string InverterString(string str)
        {
            int tamanho = str.Length;
            char[] caracter = new char[tamanho];
            for (int contador = 0; contador < tamanho; contador++)
            {
                caracter[contador] = str[tamanho - 1 - contador];
            }
            return new string(caracter);
        }

        public static int BinarioParaDecimal(string Binario)
        {
            int exp = 0;
            int soma = 0;
            int num;

            string numInvertido = InverterString(Binario);
            for (int cont = 0; cont < numInvertido.Length; cont++)
            {
                num = Convert.ToInt32(numInvertido.Substring(cont, 1));

                //multiplica o dígito por 2 elevado ao expoente, e armazena o resultado em soma

                soma += num * (int)Math.Pow(2, exp);
                exp++;

            }

            return soma;

        }
    }
}
