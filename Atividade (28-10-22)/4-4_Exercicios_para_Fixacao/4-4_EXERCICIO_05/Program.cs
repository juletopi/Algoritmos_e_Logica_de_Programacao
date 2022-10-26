using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 05:

            // As lojas de um shopping center estão concedendo 10% de desconto no preço de qualquer
            // produto. Elabore um algoritmo que a partir do valor fornecido, calcule e exiba o
            // preço atual e o preço com desconto.

            // Variáveis:
            double valor_produto = 0, valor_desconto = 0;
            double desconto = 10;
            string produto;

            // Entrada de Dados:
            Console.WriteLine("Digite o nome do produto:");
            produto = Console.ReadLine();
            Console.WriteLine("\r\nDigite o valor do produto:");
            valor_produto = double.Parse(Console.ReadLine());

            // Processamento:
            valor_desconto = valor_produto - (valor_produto * (desconto / 100));

            // Saída dos Dados:
            Console.WriteLine("\r\nO valor do produto " +produto +", é de: R$" +valor_produto +"\r\nO valor deste produto, com desconto de 10%, é de: R$" +valor_desconto);
            Console.ReadKey();
        }
    }
}