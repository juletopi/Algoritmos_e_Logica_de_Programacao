using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 02

            // Some os números de 1 a 100 a imprima o valor.

            // Variáveis:
            int soma = 0;

            // Entrada, Processamento e Saída de Dados:
            
            for (int i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }

            Console.Write("\r\n ┌──────────────────────────────────────────────┐");
            Console.Write("\r\n │ Some os números de 1 a 100 a imprima o valor │");
            Console.Write("\r\n └──────────────────────────────────────────────┘\r\n");
            Console.WriteLine("\r\nA soma dos números de 1 a 100, é: " +soma);

            Console.ReadKey();
        }
    }
}