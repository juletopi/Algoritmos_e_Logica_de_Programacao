using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 06:

            // Verifique se o número fornecido pelo usuário é par ou ímpar. Para isto,
            // apresente uma mensagem mostrando o número digitado e o resultado do teste.

            // Variáveis:
            double num = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (num % 2 == 0)
            {
                Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste é um número PAR!");
            }
            else
            {
                Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste é um número ÍMPAR!");
            }
            Console.ReadKey();
        }
    }
}