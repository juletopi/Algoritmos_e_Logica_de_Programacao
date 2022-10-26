using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 01:

            // Leia 4 valores, calcule a soma entre eles e apresente o resultado.

            // Variáveis:
            double valor1 = 0, valor2 = 0, valor3 = 0, valor4 = 0;
            double soma;

            // Entrada de Dados:
            Console.WriteLine("Digite 4 valores:");
            valor1 = double.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());
            valor3 = double.Parse(Console.ReadLine());
            valor4 = double.Parse(Console.ReadLine());

            // Processamento:
            soma = valor1 + valor2 + valor3 + valor4;

            // Saída dos Dados:
            Console.WriteLine("\r\nOs números somados são: " +soma +"\r\nConta finalizada!");
            Console.ReadKey();
        }
    }
}