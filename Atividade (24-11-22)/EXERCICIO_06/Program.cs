using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 06

            // Faça um algoritmo que calcule a média de salários de uma
            // empresa, pedindo ao usuário a quantidade de funcionários, o
            // nome e o salário de cada funcionário. Ao fim apresenta a média
            // dos salários, o salário mais alto e o salário mais baixo.

            // Variáveis:
            string nome, option;
            double salario = 0, quantidade = 0, media= 0, soma = 0, maior = 0, menor = 0;

            // Entrada, Processamento e Saída de Dados:
            do
            {
                Console.Write("\r\n ┌─────────────────────────┐");
                Console.Write("\r\n │ Cadastro de Funcionário │");
                Console.Write("\r\n └─────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite o nome completo do funcionário: ");
                nome = Console.ReadLine();
                Console.WriteLine("\r\nDigite o salário do funcionário (somente números): ");
                salario = double.Parse(Console.ReadLine());

                Console.Write("\r\n ┌─────────────────────────────────┐");
                Console.Write("\r\n │ Deseja realizar outro cadastro? │");
                Console.Write("\r\n └─────────────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite S para SIM ou N para NÃO... \r\n");
                option = Console.ReadLine().ToUpper();

            } while (option == "S");

            Console.Write("\r\n ┌───────────────────────────────────────────┐");
            Console.Write("\r\n │ Programa finalizado! Os resultados são... │");
            Console.Write("\r\n └───────────────────────────────────────────┘\r\n");

            media = soma / quantidade;

            if (maior > salario)
            {
                maior = salario;
                if (maior < salario)
                {
                    menor = salario;
                }
            }
            if (menor < salario)
            {
                menor = salario;
                if (menor > salario)
                {
                    maior = salario;
                }
            }
            // A média dos salários:
            Console.WriteLine("A média dos salários: R$" +media.ToString("F"));

            // O salário mais alto:
            Console.WriteLine("O salário mais alto: R$" +maior.ToString("F"));

            // O salário mais baixo:
            Console.WriteLine("O salário mais baixo: R$" +menor.ToString("F"));

        Console.ReadKey();
        }
    }
}