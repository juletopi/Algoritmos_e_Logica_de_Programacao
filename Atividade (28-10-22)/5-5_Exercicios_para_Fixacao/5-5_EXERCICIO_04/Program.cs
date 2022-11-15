using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 04:

            // Considerando a sequência de Fibonacci (1, 2, 3, 5, 8, 13...) elabore um algoritmo
            // para gerar esta sequência até o enésimo termo, fornecido pelo usuário. Por exemplo
            // se usuário digitou o número 40 deverão ser gerados os primeiros 40 números.

            // Variáveis:
            int b = 0, c = 1;
            int sequencia;
            int i, a;

            // Entrada de Dados:
            Console.WriteLine("Defina um índice para gerar a sequência de Fibonacci:");
            sequencia = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nExibindo a sequência de Fibonacci até o " +sequencia +"º termo...");
            Console.WriteLine("");

            // Processamento e Saída de Dados:
            
            for (i = 0; i < sequencia; i++)
            {
                a = (b + c);
                b = c;
                c = a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}