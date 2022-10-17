using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 07:

            // Construa um algoritmo que leia 5 valores inteiros e positivos, e:
            // Encontre o maior valor.
            // Encontre o menor valor.
            // Calcule a média dos números lidos.

            // Variáveis:

            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            int valor5 = 0;
            double maior = 0;
            double menor = 0;  

            // Entrada de Dados:
            Console.WriteLine("Digite o primeiro valor (inteiro e positivo):");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor (inteiro e positivo):");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor (inteiro e positivo):");
            valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor (inteiro e positivo):");
            valor4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quinto valor (inteiro e positivo):");
            valor5 = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:

            maior = valor1;

            if (maior < valor2)
            {
                maior = valor2;
            }
            else if (maior < valor3)
            {
                maior = valor3;
            }
            else if (maior < valor4)
            {
                maior = valor4;
            }
            else if (maior < valor5)
            {
                maior = valor5;
            }

            else if (menor > valor2)
            {
                menor = valor2;
            }
            else if (menor > valor3)
            {
                menor = valor3;
            }
            else if (menor > valor4)
            {
                menor = valor4;
            }
            else if (menor > valor5)
            {
                menor = valor5;
            }
            Console.WriteLine("O maior número é o: " +maior);
            Console.WriteLine("O menor número é o: " +menor);
            Console.WriteLine("Conta finalizada!");
            Console.ReadKey();
        }
    }
}