using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 07:

            // Melhore o algoritmo do exercício anterior (Exercício 06), verificando se o número
            // inserido pelo usuário é zero/neutro, par ou ímpar.

            // Variáveis:
            double num = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (num == 0)
            {
                Console.WriteLine("O número escolhido foi: " + num);
                Console.WriteLine("Este é um número ZERADO/NEUTRO!");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("O número escolhido foi: " + num);
                    Console.WriteLine("Este é um número PAR!");
                }
                else
                {
                    Console.WriteLine("O número escolhido foi: " + num);
                    Console.WriteLine("Este é um número ÍMPAR!");
                }
            }
            Console.ReadKey();
        }
    }
}