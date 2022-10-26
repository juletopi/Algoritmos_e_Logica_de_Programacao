using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 03:

            // Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
            // para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
            // a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
            // exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
            // comprada, o valor unitário e o valor total.

            // Variáveis:
            double valor_unit, valor_total;
            double quantidade;
            string nome, code;

            // Entrada de Dados:
            Console.WriteLine("Digite o código do produto:");
            code = Console.ReadLine();
            Console.WriteLine("\r\nDigite o nome do produto:");
            nome = Console.ReadLine();
            Console.WriteLine("\r\nDigite a quantidade comprada:");
            quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nDigite o valor unitário do produto:");
            valor_unit = double.Parse(Console.ReadLine());

            // Processamento:
            valor_total = quantidade * valor_unit;

            // Saída dos Dados:
            Console.WriteLine("\r\nCódigo do produto - #" +code);
            Console.WriteLine("Nome do produto - " +nome);
            Console.WriteLine("Quantidade comprada - " +quantidade);
            Console.WriteLine("Valor unitário do produto - R$" +valor_unit);
            Console.WriteLine("Valor total da venda - R$" +valor_total);
            Console.ReadKey();
        }
    }
}