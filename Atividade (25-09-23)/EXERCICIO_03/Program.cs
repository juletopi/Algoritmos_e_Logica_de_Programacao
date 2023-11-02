using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Elabore um algoritmo que seja capaz de fazer a conversão de um valor em real,
            // para o correspondente em dólar, libra, franco e iene, e vice-versa.
            // O programa deverá conter um menu com as opções e retornar os resultados
            // para o programa principal, encarregado da exibição dos resultados.

            Console.Write("\r\n ┌─────────────────────┐");
            Console.Write("\r\n │ Conversão de Moedas │");
            Console.Write("\r\n └─────────────────────┘\r\n");

            while (true)
            {
                // Menu de opções para o usuário
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\r\n 1. Converter Real para outras moeadas");
                Console.WriteLine(" 2. Converter outras moedas para Real");
                Console.WriteLine(" 3. Sair");
                Console.WriteLine("\r\n -----------------------------------------");
                Console.Write("\r\n Digite o nº da opção desejada: ");


                int opcEscolha = Convert.ToInt32(Console.ReadLine());

                switch (opcEscolha)
                {
                    case 1:
                        // Opção 1 - Converter Real para outras moedas
                        ConversaoRealParaOutrasMoedas();
                        break;
                    case 2:
                        // Opção 2 - Converter outras moeadas para Real
                        ConversaoOutrasMoedasParaReal();
                        break;
                    case 3:
                        // Opção 3 - Sair do programa
                        Console.WriteLine(" Saindo do programa... Desligando agora, até mais!");
                        return;
                    default:
                        Console.WriteLine("\r\n Opção inválida! Por favor, selecione uma opção válida.");
                        break;
                }
            }
        }

        // Função: Converter Real para outras moedas
        static void ConversaoRealParaOutrasMoedas()
        {
            Console.Write("\r\n Digite o valor em Reais (BRL): ");
            double valorReal = Convert.ToDouble(Console.ReadLine());

            double valorDolar = valorReal * 5.4;
            double valorLibra = valorReal * 7.2;
            double valorFrancoSuico = valorReal * 5.8;
            double valorIene = valorReal * 0.049;

            Console.WriteLine("\r\n Valor convertido em Dólar (USD): $" + valorDolar.ToString("F2")); // 1 BRL = 5.4 USD
            Console.WriteLine(" Valor convertido em Libras (GBP): £" + valorLibra.ToString("F2")); // 1 BRL = 7.2 GPB
            Console.WriteLine(" Valor convertido em Francos Suíços (CHF): CHF" + valorFrancoSuico.ToString("F2"));// 1 BRL = 5.8 CHF
            Console.WriteLine(" Valor convertido em Ienes (JPY): ¥" + valorIene.ToString("F2")); // 1 BRL = 0.049 JPY
        }

        // Função: Converter outras moeadas para Real
        static void ConversaoOutrasMoedasParaReal()
        {
            Console.Write("\r\n Digite o valor em qualquer outra moeda: ");
            double valorMoeda = Convert.ToDouble(Console.ReadLine());

            double valorReal = valorMoeda / 5.4; // 1 USD = 5.4 BRL
            Console.WriteLine("\r\n Valor em Reais (BRL): R$" + valorReal.ToString("F2"));

            Console.ReadKey();
        }
    }
}