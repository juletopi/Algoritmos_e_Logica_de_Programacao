using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 05:

            // Elabore um algoritmo que a partir do número (n) fornecido pelo usuário,
            // execute os cálculos e seguir, enquanto este número for diferente de 1.

            // a) Se n for par, n = n ÷ 2
            // b) Se n for ímpar, n = n x 3 + 1
            
            // Variáveis:
            double num = 0;
            double calc_par, calc_impar;

            // Entrada de Dados:
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:

            if (num % 2 == 0)
            {
                calc_par = (num / 2);
                Console.WriteLine("\r\nSeu número é PAR, e o seu cálculo de (n = n ÷ 2) é: " +calc_par +"\r\nConta finalizada!");
            }
            else
            {
                calc_impar = (num * 3 + 1);
                Console.WriteLine("\r\nSeu número é ÍMPAR, e o seu cálculo de (n = n x 3 + 1) é: " +calc_impar +"\r\nConta finalizada!");
            }
            Console.ReadKey();
        }
    }
}