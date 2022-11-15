using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 02:

            // Elabore um algoritmo que calcule e exiba a tabuada, até um determinado número (n),
            // fornecido pelo usuário, lembrando que, se o número fornecido é 4, deve ser gerada
            // a tabuada do 1, 2, 3 e 4, com as operações de multiplicação e resultado no formato:

            // 1 x 2 = 1
            // 1 x 2 = 2
            // 1 x 3 = 3...

            // Variáveis:
            int i = 0, j = 0;
            int contador;

            // Entrada de Dados:
            Console.WriteLine("Até qual valor você deseja exibir a tabuada?");
            contador = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nExibindo a tabuada até " +contador +"...");
            Console.WriteLine("");

            // Processamento e Saída de Dados:

            for (i = 1; i <= contador; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            Console.ReadKey();
        }
    }
}