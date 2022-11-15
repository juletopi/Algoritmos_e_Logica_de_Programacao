using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 03:

            // A partir de um conjunto de números inteiros sequenciais obtidos com base em dados
            // fornecidos pelo usuário (número inicial e número final) identifique e apresente:

            // a) A quantidade de números inteiros e positivos.
            // b) A quantidade números pares.
            // c) A quantidade números ímpares.
            // d) A quantidade números ímpares divisíveis por 3 e 7.
            // e) A respectiva média para cada um dos itens.

            // Variáveis:
            double num_inicial = 0, num_final = 0;
            double num_positivo = 0, num_par = 0, num_impar = 0, num_3_7 = 0;
            double soma_positivo = 0, soma_par = 0, soma_impar = 0, soma_3_7 = 0;
            double media_positivo = 0, media_par = 0, media_impar = 0, media_3_7 = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite o seu número inicial: ");
            num_inicial = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nDigite o seu número final: ");
            num_final = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:

            do
            {
                num_inicial++;

                if (num_inicial > 0)
                {
                    num_positivo++;
                    soma_positivo += num_inicial;

                    if (num_inicial % 2 == 0)
                    {
                        num_par++;
                        soma_par += num_inicial;
                    }
                    else
                    {
                        if (num_inicial % 3 == 0 && num_inicial % 7 == 0)
                        {
                            num_3_7++;
                            soma_3_7 += num_inicial;
                        }
                        num_impar++;
                        soma_impar += num_inicial;
                    }
                }
            }
            while (num_inicial <= num_final);

            media_positivo = soma_positivo / num_impar;
            media_par = soma_par / num_par;
            media_impar = soma_impar / num_impar;

            if (num_3_7 == 0)
            {
                media_3_7 = soma_3_7 / 1;
            }
            else
            {
                media_3_7 = soma_3_7 / num_3_7;
            }

            Console.Write("\r\n ┌──────────────────────────────────────────────┐");
            Console.Write("\r\n │ Dentro do intervalo dos números digitados... │");
            Console.Write("\r\n └──────────────────────────────────────────────┘\r\n");
            // a) A quantidade de números inteiros e positivos.
            Console.WriteLine("\r\nHá " +num_positivo +" número(s) inteiro(s) e positivo(s).");

            // b) A quantidade números pares.
            Console.WriteLine("Há " +num_par +" número(s) par(es).");

            // c) A quantidade números ímpares.
            Console.WriteLine("Há " + num_impar +" número(s) par(es).");

            // d) A quantidade números ímpares divisíveis por 3 e 7.
            Console.WriteLine("Há " +num_3_7 + " número(s) ímpar(es) divisível(is) por 3 e 7.");

            // e) A respectiva média para cada um dos itens.
            Console.Write("\r\n ┌────────────────────────────┐");
            Console.Write("\r\n │ Média dos Itens Anteriores │");
            Console.Write("\r\n └────────────────────────────┘\r\n");
            Console.WriteLine("\r\nMédia dos números inteiros e positivos: " + media_positivo);
            Console.WriteLine("Média dos números pares: " +media_par);
            Console.WriteLine("Média dos números ímpares: " +media_impar);
            Console.WriteLine("Média dos números ímpares divisíveis por 3 e 7: " +media_3_7);

            Console.ReadKey();
        }
    }
}