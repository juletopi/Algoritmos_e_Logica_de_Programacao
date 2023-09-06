using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo feito em aula (Cadastro de clientes, produtos e preços)

            // Matrizes são usadas para organizar e manipular dados de maneira eficiente em 
            // uma estrutura tabular. Elas permitem armazenar informações relacionadas em 
            // um formato de grade, o que facilita o acesso rápido a elementos específicos.

            string[] nomeCliente;
            int[] quantProd;
            double[] precoProdTotal;
            double[][] precoProd;
            string[][] nomeProd;

            Console.WriteLine("Quantos clientes deseja cadastrar? ");
            int quant = Convert.ToInt32(Console.ReadLine());

            nomeCliente = new string[quant];
            quantProd = new int[quant];
            precoProd = new double[quant][];
            nomeProd = new string[quant][];

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("\r\nDigite o nome do Cliente:");
                nomeCliente[i] = Console.ReadLine();
                Console.Write("Digite quantos produtos este cliente quer comprar: ");
                quantProd[i] = Convert.ToInt32(Console.ReadLine());

                precoProd[i] = new double[quantProd[i]];
                nomeProd[i] = new string[quantProd[i]];

                for (int j = 0; j < quantProd[i]; j++)
                {
                    Console.Write("\r\nDigite o NOME do produto do cliente: " + nomeCliente[i]);
                    nomeProd[i][j] = Console.ReadLine();
                    Console.Write("Digite o PREÇO do produto do cliente: " + nomeCliente[i]);
                    precoProd[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Mostrar os dados

            Console.Write("Carregando.");
            for (int i = 0; i < 60; i++)
            {
                System.Threading.Thread.Sleep(30);
                Console.Write(".");
            }

            Console.WriteLine("");
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Cliente: " + nomeCliente[i]);
                Console.WriteLine("Este cliente comprou " + quantProd[i] + " produtos.");

                for (int j = 0; j < quantProd[i]; j++)
                {
                    Console.WriteLine("\r\nO " + (j + 1) + "º produto é: " + nomeProd[i][j]);
                    Console.WriteLine("O " + (j + 1) + "º produto tem o valor de: " + precoProd[i][j]);
                }

                // Calcular o valor total das compras aqui, se necessário

            }
        }
    }
}
