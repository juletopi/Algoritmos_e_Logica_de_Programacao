using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 08:

            // De acordo com o valor fornecido pelo usuário, verifique se ele é múltiplo de 3 ou múltiplo
            // de 7. Apresente uma mensagem mostrando o número digitado e o resultado do teste.

            // Variáveis:
            double num = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (num == 0)
            {
                Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste é um número NEUTRO!");
            }
            else
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste é um número multiplo de 3!");
                }
                if (num % 7 == 0)
                {
                    Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste é um número multiplo de 7!");
                }
                else
                {
                    if (num % 3 != 0 && num % 3 != 0)
                    {
                        Console.WriteLine("\r\nO número escolhido foi: " +num +"\r\nEste número não é multiplo de 3 ou 7!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}