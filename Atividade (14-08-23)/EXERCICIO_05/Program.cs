using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Elabore um algoritmo que crie dois vetores A e B de 10 elementos e, a partir
            // deles, crie um vetor C, composto pela união dos elementos de A e B,
            // dispostos em ordem crescente, exibindo o resultado.

            int tamanho = 10;

            double[] A = new double[tamanho];
            double[] B = new double[tamanho];
            double[] C = new double[tamanho * 2];

            // I) Preenchendo os vetores/arrays A e B
            Console.Write("\r\n ┌────────────────────────────────────────┐");
            Console.Write("\r\n │ União de 10 valores em ordem crescente │");
            Console.Write("\r\n └────────────────────────────────────────┘\r\n");
            Console.WriteLine("");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(" Digite o valor para A" + (i + 1) + ": ");
                A[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Digite o valor para B" + (i + 1) + ": ");
                B[i] = Convert.ToDouble(Console.ReadLine());
            }

            // II) Criando o vetor/array C com as somas em ordem crescente
            int numA = 0;
            int numB = tamanho;

            for (int i = 0; i < tamanho * 2; i++)
            {
                if (numA < tamanho && (numB >= tamanho * 2 || A[numA] <= B[numB - tamanho]))
                {
                    C[i] = A[numA];
                    numA++;
                }
                else
                {
                    C[i] = B[numB - tamanho];
                    numB++;
                }
            }

            // III) Imprimindo os vetores/arrays A, B e C
            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────┐");
            Console.Write("\r\n │ Resultados │");
            Console.Write("\r\n └────────────┘\r\n");

            Console.WriteLine(" \r\n Valores A (inseridos): " + string.Join(", ", A));
            Console.WriteLine(" Valor B (inseridos): " + string.Join(", ", B));
            Console.WriteLine(" Valor C (união em ordem crescente): " + string.Join(", ", C));

            Console.WriteLine("");
            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}