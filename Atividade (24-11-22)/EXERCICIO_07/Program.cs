using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 07

            // Escreva um algoritmo que você fez durante o semestre. 

            // "Tabuada_CSharp"

            // Variáveis:
            int i, n, m;
            int resultado;

            // Entrada de Dados:
            Console.WriteLine("Defina um número para exibir a tabuada dele:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nQuantas vezes?");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // Processamento e Saída de Dados:
            for (i = 1; i <= m; i++)
            {
                resultado = n * i;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }

            Console.ReadKey();
        }
    }
}