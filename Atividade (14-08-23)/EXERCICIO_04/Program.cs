using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
            // a partir deles, crie um vetor C, composto pela somados elementos, sendo: 

            // C[1] = A[1] + B[10], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.

            int tamanho = 10;

            double[] A = new double[tamanho];
            double[] B = new double[tamanho];
            double[] C = new double[tamanho];

            // I) Preenchendo os vetores/arrays A e B
            Console.Write("\r\n ┌─────────────────────────────────────┐");
            Console.Write("\r\n │ Soma de 10 valores em ordem reversa │");
            Console.Write("\r\n └─────────────────────────────────────┘\r\n");
            Console.WriteLine("");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(" Digite o valor para A" + (i + 1) + ": ");
                A[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Digite o valor para B" + (i + 1) + ": ");
                B[i] = Convert.ToDouble(Console.ReadLine());
            }

            // II) Criando o vetor/array C com as somas
            for (int i = 0; i < tamanho; i++)
            {
                C[i] = A[i] + B[tamanho - i - 1];
            }

            // III) Imprimindo os vetores/arrays A, B e C
            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────┐");
            Console.Write("\r\n │ Resultados │");
            Console.Write("\r\n └────────────┘\r\n");

            Console.WriteLine(" \r\n Valores A (inseridos): " + string.Join(", ", A));
            Console.WriteLine(" Valor B (inseridos): " + string.Join(", ", B));
            Console.WriteLine(" Valor C (somas): " + string.Join(", ", C));

            Console.WriteLine("");
            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}