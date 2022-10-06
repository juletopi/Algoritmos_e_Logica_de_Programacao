using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 04:

            // Faça um algoritmo que leia um número inteiro e mostre uma mensagem indicando
            // se este número é par ou impar, e se é positivo ou negativo.

            // Variáveis:

            int num = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite um número (posivo ou negativo):");
            num = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (num == 0)
            {
                Console.WriteLine("O seu número é NEUTRO, não ente bugar o sitema, espertinho >:(");
                Console.WriteLine("Conta finalizada!");
            }
            else if (num % 2 == 0 && num >= 0)
            {
                Console.WriteLine("O seu número é PAR e POSITIVO");
                Console.WriteLine("Conta finalizada!");
            }
            else if (num % 2 == 0 && num < 0)
            {
                Console.WriteLine("O seu número é PAR e NEGATIVO");
                Console.WriteLine("Conta finalizada!");
            }
            else if (num % 2 != 0 && num >= 0)
            {
                Console.WriteLine("O seu número é ÍMPAR e POSITIVO");
                Console.WriteLine("Conta finalizada!");
            }
            else
            {
                Console.WriteLine("O seu número é ÍMPAR e NEGATIVO");
                Console.WriteLine("Conta finalizada!");
            }
            Console.ReadKey();
        }
    }
}
