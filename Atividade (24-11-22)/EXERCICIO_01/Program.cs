using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 01

            // Crie um programa que peça 10 números inteiros
            // e apresente a média, a soma e o menor.

            // Variáveis:
            int num = 0, soma = 0, menor = 0;
            double media = 0;

            // Entrada, Processamento e Saída de Dados:
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite 10 numeros inteiros: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (menor == 0)
                {
                    menor = num;
                }
                else
                {
                    if (menor > num)
                    {
                        menor = num;
                    }
                }
                soma = soma + num;
                media = soma / 10;
            }
            Console.Write("\r\n ┌─────────────┐");
            Console.Write("\r\n │ Resultados: │");
            Console.Write("\r\n └─────────────┘\r\n");
            Console.WriteLine("\r\nMédia dos Números: " +media);
            Console.WriteLine("Soma dos Números: " +soma);
            Console.WriteLine("Menor Número: " +menor);

            Console.ReadKey();
        }
    }
}