using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 02:

            // Leia 3 valores, calcule a média aritmética entre eles e apresente o resultado.

            // Variáveis:
            double valor1 = 0, valor2 = 0, valor3 = 0;
            double total;
            double media_a;

            // Entrada de Dados:
            Console.WriteLine("Digite 3 valores:");
            valor1 = double.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());
            valor3 = double.Parse(Console.ReadLine());

            // Processamento:
            total = valor1 + valor2 + valor3;
            media_a = total / 3;

            // Saída dos Dados:
            Console.WriteLine("\r\nA média aritmética dos números é: " +media_a +"\r\nConta finalizada!");
            Console.ReadKey();
        }
    }
}