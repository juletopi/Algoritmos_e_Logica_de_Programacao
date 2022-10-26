using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 10:

            // Uma loja de departamentos está oferecendo diferentes formas de pagamento, conforme as opções
            // mostradas a seguir. Elabore um algoritmo que leia o valor total de uma compra e calcule o
            // valor do pagamento final de acordo com a opção escolhida. Se a escolha for por pagamento
            // parcelado, calcule também o valor da parcela. Ao final, apresente o valor total e o
            // valor das parcelas.

            // Pagamento a vista - Conceder desconto de 5%
            // Pagamento em 3 parcelas - O valor não sofre alteração
            // Pagamento em 5 parcelas - Acréscimo de 2%
            // Pagamento em 10 parcelas - Acréscimo de 8%

            // Variáveis:
            double total;
            double pagamento;
            double desconto_5;
            double parcela_3;
            double parcela_5;
            double parcela_10;

            // Entrada de Dados:
            Console.WriteLine("Digite o valor total da sua compra:");
            total = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nEscolha dentre as opções de pagamento:\r\n");
            Console.WriteLine("(1) Pagamento a vista - Conceder desconto de 5%");
            Console.WriteLine("(2) Pagamento em 3 parcelas - O valor não sofre alteração");
            Console.WriteLine("(3) Pagamento em 5 parcelas - Acréscimo de 2%");
            Console.WriteLine("(4) Pagamento em 10 parcelas - Acréscimo de 8%\r\n");
            Console.WriteLine("Qual será a sua forma de pagamento?");
            pagamento = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:

            if (pagamento == 1)
            {
                desconto_5 = (total * 0.05);
                total = (total - desconto_5);
                Console.WriteLine("\r\nO valor total é: R$" +total +"\r\nVocê economizou: R$" +desconto_5);
            }
            if (pagamento == 2)
            {
                parcela_3 = (total / 3);
                total = (parcela_3 * 3);
                Console.WriteLine("\r\nO valor total das parcelas é: R$" +parcela_3);
                if (total == total)
                {
                    Console.WriteLine("Sem alteração no valor, o valor total é: R$" +total);
                }
            }
            if (pagamento == 3)
            {
                parcela_5 = (total * 0.02);
                total = (total + parcela_5);
                parcela_5 = (total / 5);
                Console.WriteLine("\r\nO valor total das parcelas é: R$" +parcela_5 +"\r\nO valor total é: R$" +total);
            }
            if (pagamento == 4)
            {
                parcela_10 = (total * 0.08);
                total = (total + parcela_10);
                parcela_10 = (total / 10);
                Console.WriteLine("\r\nO valor total das parcelas é: R$" +parcela_10 +"\r\nO valor total é: R$" +total);
            }
            Console.ReadKey();
        }
    }
}