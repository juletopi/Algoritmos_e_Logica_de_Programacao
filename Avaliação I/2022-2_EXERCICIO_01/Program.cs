using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2_EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 01

            // Crie um programa que peça 20 números e apresente a média, a soma e o maior número. 

            // Variáveis:
            int num = 0, soma = 0, maior = 0;
            double media = 0;

            // Entrada, Processamento e Saída de Dados:

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite 20 números inteiros: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (maior == 0)
                {
                    maior = num;
                }
                else
                {
                    if (maior < num)
                    {
                        maior = num;
                    }
                }
                soma = soma + num;
                media = soma / 20;
            }
            Console.Write("\r\n ┌─────────────┐");
            Console.Write("\r\n │ Resultados: │");
            Console.Write("\r\n └─────────────┘\r\n");
            Console.WriteLine("\r\nMédia dos Números: " + media);
            Console.WriteLine("Soma dos Números: " + soma);
            Console.WriteLine("Maior Número: " + maior);

            Console.ReadKey();
        }
    }
}