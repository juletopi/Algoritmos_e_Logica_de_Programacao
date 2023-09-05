using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Faça um cadastro de fazendeiros, onde cada fazendeiro tem diferentes tipos de gado
            // (bezerro, novilha, garote, vaca, boi) e cada tipo tem valor e quantidade diferente.

            // I) Cadastrando os fazendeiros e a quant. de gados para cadastrar
            Console.Write("\r\n ┌─────────────────────────────────────────────────┐");
            Console.Write("\r\n │ Cadastro de fazendeiros, gados e quant. do gado │");
            Console.Write("\r\n └─────────────────────────────────────────────────┘\r\n");
            Console.WriteLine(" ");

            Console.WriteLine(" Quantos fazendeiros você deseja cadastrar?");
            int quantFazendeiros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Quantos gados cada fazendeiro tem?");
            int quantGados = Convert.ToInt32(Console.ReadLine());

            string[][] nomesFazendeiros = new string[quantFazendeiros][];
            string[][] nomesGados = new string[quantFazendeiros][];
            double[][] quantDoGado = new double[quantFazendeiros][];

            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌─────────────────────────────────────────────────┐");
            Console.Write("\r\n │ Informando os dados dos fazendeiros cadastrados │");
            Console.Write("\r\n └─────────────────────────────────────────────────┘\r\n");

            for (int i = 0; i < quantFazendeiros; i++)
            {
                Console.Write(" \r\n Digite o nome do fazendeiro nº" + (i + 1) + ": ");
                string nomedoFazendeiro = Console.ReadLine();
                Console.WriteLine(" ");

                // II) Iniciando as matrizes internas a partir do número de gados
                nomesFazendeiros[i] = new string[] { nomedoFazendeiro };
                nomesGados[i] = new string[quantGados];
                quantDoGado[i] = new double[quantGados];

                for (int j = 0; j < quantGados; j++)
                {
                    Console.Write(" Digite o nome do gado nº" + (j + 1) + " para o fazendeiro " + nomedoFazendeiro + ": ");
                    nomesGados[i][j] = Console.ReadLine();

                    Console.Write(" Digite a quantidade de cabeças do gado nº" + (j + 1) + " para o fazendeiro " + nomedoFazendeiro + ": ");
                    quantDoGado[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // III) Imprimindo os dados dos alunos e as suas notas
            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────┐");
            Console.Write("\r\n │ Resultados │");
            Console.Write("\r\n └────────────┘\r\n");

            for (int i = 0; i < quantFazendeiros; i++)
            {
                Console.WriteLine(" \r\n Fazendeiro: " + nomesFazendeiros[i][0]);
                Console.WriteLine(" Gados e Cabeças: ");
                Console.WriteLine(" ");

                for (int j = 0; j < quantGados; j++)
                {
                    Console.WriteLine(" " + nomesGados[i][j] + ": " + quantDoGado[i][j] + " Cabeças");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}