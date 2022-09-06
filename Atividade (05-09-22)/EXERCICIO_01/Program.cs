using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 01: (⁠ •⁠-⁠•⁠)👍

            // João Papo-de-Pescador, homem de bem, comprou um microcomputador para
            // controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
            // peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
            // (50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. João precisa que
            // você faça programa que leia a variável P (peso de peixes) e verifique se há excesso.
            // Se houver, gravar na variável E (Excesso) e na variável M o valor da multa que João
            // deverá pagar. Caso contrário mostrar tais variáveis com o conteúdo ZERO.

            // Variáveis:

            double P = 0;
            double E = 0;
            double M = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite o peso em quilogramas do seu peixe (somente números):");
            P = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (P >= 50)
            {
                E = (P - 50);
                Console.WriteLine("Limite excedente: 50kg");
                M = (E * 4);
                Console.WriteLine("O peso do seu peixe excede o limite, a sua multa é de: R$" +M);
            }
            else
            {
                Console.WriteLine("O peso do peixe não excede o limite, a sua multa é de: R$" +M);
            }
            Console.ReadKey();
        }
    }
}
