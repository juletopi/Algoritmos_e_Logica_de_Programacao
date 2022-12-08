using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2_EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 02

            // Tire a média dos números de 1 a 100 e imprima o valor da média.

            // Variáveis:
            double media = 0;

            // Entrada, Processamento e Saída de Dados:

            for (int i = 0; i <= 100; i++)
            {
                media = i / 100;
            }
            Console.Write("\r\n ┌──────────────────────────────┐");
            Console.Write("\r\n │ Imprimindo o valor da média: │");
            Console.Write("\r\n └──────────────────────────────┘\r\n");
            Console.WriteLine("\r\nA média dos números de 1 a 100, é: " + media);

            Console.ReadKey();
        }
    }
}