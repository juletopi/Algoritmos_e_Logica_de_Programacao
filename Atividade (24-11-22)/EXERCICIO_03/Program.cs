using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 03

            // Faça um algoritmo que leia um número inteiro e mostre uma
            // mensagem indicando se este número é par ou ímpar, e se é
            // positivo ou negativo.

            // Variáveis:
            double num = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:

            Console.Write("\r\n ┌─────────────┐");
            Console.Write("\r\n │ Resultados: │");
            Console.Write("\r\n └─────────────┘\r\n");

            if (num == 0)
            {
                Console.WriteLine("\r\nSeu número é NULO!");
            }
            if (num % 2 == 0 && num != 0)
            {
                Console.WriteLine("\r\nSeu número é PAR!");
            }
            if (num % 2 != 0 && num != 0)
            {
                Console.WriteLine("\r\nSeu número é ÍMPAR!");
            }
            if (num > 0 && num != 0)
            {
                Console.WriteLine("Seu número é POSITIVO!");
            }
            if (num < 0 && num != 0)
            {
                Console.WriteLine("Seu número é NEGATIVO!");
            }
            Console.ReadKey();
        }
    }
}