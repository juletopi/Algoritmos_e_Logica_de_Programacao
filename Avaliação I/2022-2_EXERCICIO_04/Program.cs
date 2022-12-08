using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2_EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 04

            // Faça um algoritmo que leia números até o usuário digitar 0, após 
            // finalizar, mostre quantos números foram lidos, a soma e quantos são ímpares.

            // Variáveis:
            int quantidade = 0, soma = 0, num = 0, num_impar = 0;

            // Entrada, Processamento e Saída de Dados:

            do
            {
                Console.WriteLine("Digite um número (Digite 0 (zero) quando quiser parar): ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                quantidade++;
                soma = soma + num;

                if (num % 2 != 0 && num != 0)
                {
                    num_impar++;
                }

            } while (num != 0);

            Console.Write("\r\n ┌─────────────┐");
            Console.Write("\r\n │ Resultados: │");
            Console.Write("\r\n └─────────────┘\r\n");
            Console.WriteLine("\r\nA quantidade de números lidos é: " +quantidade);
            Console.WriteLine("A soma dos números lidos é: " +soma);
            Console.WriteLine("A quantidade de números ímpares é: " +num_impar);

            Console.ReadKey();
        }
    }
}