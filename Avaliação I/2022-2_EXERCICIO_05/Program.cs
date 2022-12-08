using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2_EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 05

            // Faça um algoritmo que calcule a média de produtos de uma 
            // compra, pedindo ao usuário a quantidade de produtos, o nome
            // e valor de cada produto. Ao fim apresenta a média do valor
            // dos produtos, o produto mais caro e o produto mais baixo.

            // Variáveis:
            string nome, option;
            double valor = 0, quantidade = 0, media = 0, maior_produto = 0, menor_produto = 0;

            // Entrada, Processamento e Saída de Dados:
            do
            {
                Console.Write("\r\n ┌─────────────────────┐");
                Console.Write("\r\n │ Cadastro de Produto │");
                Console.Write("\r\n └─────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite a quantidade de produtos que quer comprar: ");
                quantidade = double.Parse(Console.ReadLine());
                quantidade++;

                Console.WriteLine("\r\nDigite o nome do produto que quer comprar: ");
                nome = Console.ReadLine();
                Console.WriteLine("\r\nDigite o valor do produto (somente números): ");
                valor = double.Parse(Console.ReadLine());

                Console.Write("\r\n ┌─────────────────────────────────┐");
                Console.Write("\r\n │ Deseja cadastrar outro produto? │");
                Console.Write("\r\n └─────────────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite S para SIM ou N para NÃO... \r\n");
                option = Console.ReadLine().ToUpper();

            } while (option == "S");

            Console.Write("\r\n ┌───────────────────────────────────────────┐");
            Console.Write("\r\n │ Programa finalizado! Os resultados são... │");
            Console.Write("\r\n └───────────────────────────────────────────┘\r\n");

            media = valor / quantidade;

            if (maior_produto < valor)
            {
                maior_produto = valor;
                if (maior_produto < valor)
                {
                    maior_produto = valor;
                }
            }
            else if (menor_produto > valor)
            {
                menor_produto = valor;
                if (menor_produto > valor)
                {
                    menor_produto = valor;
                }
            }
            Console.WriteLine("A quantidade de produtos: " +quantidade);

            // A média do valor dos produtos:
            Console.WriteLine("A média do valor dos produtos: R$" +media.ToString("F"));

            // O produto mais caro:
            Console.WriteLine("O produto mais caro: R$" +maior_produto.ToString("F"));

            // O produto mais baixo:
            Console.WriteLine("O produto mais baixo: R$" +menor_produto.ToString("F"));

            Console.ReadKey();
        }
    }
}