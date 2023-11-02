using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Escreva um algoritmo para ordenar três números fornecidos
            // pelo usuário, utilizando a passagem de parâmetros formais.

            Console.Write("\r\n ┌─────────────────────────────────┐");
            Console.Write("\r\n │ Ordenação de números aleatórios │");
            Console.Write("\r\n └─────────────────────────────────┘\r\n");
            Console.WriteLine("");

            bool continuar = true;

            do
            {
                // Obtendo os números pelo usuário.
                Console.Write(" Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Digite o terceiro número: ");
                double terceiroNumero = Convert.ToDouble(Console.ReadLine());

                // Imprimindo o resultado.
                Console.WriteLine("\r\n -----------------------------------------");

                Console.Write("\r\n ┌───────────┐");
                Console.Write("\r\n │ Resultado │");
                Console.Write("\r\n └───────────┘\r\n");

                // Chamando a função "OrdenarNumeros" e armazenando os números ordenados na tupla "numerosOrdenados".
                (double, double, double) numerosOrdenados = OrdenarNumeros(primeiroNumero, segundoNumero, terceiroNumero);

                Console.WriteLine("\r\n Os seus números ordenados são... ");
                Console.WriteLine(" Números ordenados: {0}, {1}, {2}", numerosOrdenados.Item1, numerosOrdenados.Item2, numerosOrdenados.Item3);

                Console.WriteLine("\r\n -----------------------------------------\r\n");

                Console.Write(" Deseja fazer outra operação? (s/n): ");
                char escolha = Console.ReadLine()[0];
                continuar = (escolha == 's' || escolha == 'S');

            } while (continuar);

            Console.WriteLine(" Saindo do programa... Desligando agora, até mais!");
            Console.ReadKey();
        }

        // Criando uma função para ordenar os números.
        static (double, double, double) OrdenarNumeros(double numA, double numB, double numC)
        {
            if (numA > numB)
            {
                double temp = numA;
                numA = numB;
                numB = temp;
            }

            if (numB > numC)
            {
                double temp = numB;
                numB = numC;
                numC = temp;
            }

            if (numA > numB)
            {
                double temp = numA;
                numA = numB;
                numB = temp;
            }

            return (numA, numB, numC);
        }
    }
}