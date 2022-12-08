using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 05

            // Faça um algoritmo que imprima a tabuada de 1 a 10. 

            // Variáveis:
            int resultado;

            // Entrada, Processamento e Saída de Dados:

            Console.Write("\r\n ┌────────────────────────────────┐");
            Console.Write("\r\n │ Mostrando a tabuada de 1 a 10: │");
            Console.Write("\r\n └────────────────────────────────┘\r\n");
            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine(i + " x " + j + " = " + resultado);
                }
            }
            Console.ReadKey();
        }
    }
}