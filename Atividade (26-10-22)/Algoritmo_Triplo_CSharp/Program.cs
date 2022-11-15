using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Triplo_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo Triplo

            // Elabore um algoritmo que mostre um leque de três opções que leia e resulte em:
            // 1. Uma sequência de números de forma CRESCENTE
            // 2. Uma sequência de números de forma DECRESCENTE
            // 3. Uma tabuada interativa em que o usuário escolha até onde calcular

            // Variáveis:
            int escolha = 0, indice = 0, descrescente = 0, multiplicacao = 0, resultado = 0, i;

            // Entrada de Dados:
            Console.WriteLine("Digite 1 - Para obter resultados sequênciais CRESCENTES");
            Console.WriteLine("Digite 2 - Para obter resultados sequênciais DECRESCENTES");
            Console.WriteLine("Digite 3 - Para obter uma TABUADA");

            Console.Write("\r\nInforme a opção escolhida: "); escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Processamento e Saída de Dados:
            switch (escolha)
            {
                case 1:
                Console.Write(" ┌────────────────────────────────┐");
                Console.Write("\r\n │ Números Sequênciais Crescentes │");
                Console.Write("\r\n └────────────────────────────────┘\r\n");
                Console.Write("\r\nDigite o valor que a contagem deve ir: "); indice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                   for (i = 0; i <= indice; i++)
                   {
                       Console.Write(i +"  ");
                   }
                   break;

                case 2:
                Console.Write(" ┌──────────────────────────────────┐");
                Console.Write("\r\n │ Números Sequênciais Decrescentes │");
                Console.Write("\r\n └──────────────────────────────────┘\r\n");
                Console.Write("\r\nDigite o valor que começa a contagem: "); descrescente = int.Parse(Console.ReadLine());
                Console.WriteLine();

                   for (i = descrescente; i >= 0; i--)
                   {
                       Console.Write(i +"  ");
                   }
                   break;

                case 3:
                Console.Write(" ┌────────────────────┐");
                Console.Write("\r\n │ Tabuada Interativa │");
                Console.Write("\r\n └────────────────────┘\r\n");
                Console.Write("\r\nDigite um índice: "); indice = int.Parse(Console.ReadLine());
                Console.Write("\r\nRepetir quantas vezes? "); multiplicacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                   for (i = 1; i <= multiplicacao; i++)
                   {
                       resultado = indice * i;
                       Console.WriteLine(indice +" x " +i +" = " +resultado);
                   }
                   break;

                default:
                    Console.WriteLine("Opção invalida!!!");
                break;
            }
            Console.ReadKey();
        } 
    }
}