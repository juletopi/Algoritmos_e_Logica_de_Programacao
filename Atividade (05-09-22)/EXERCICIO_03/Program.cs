using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 03: (⁠ •⁠_•⁠)👍

            // Desenvolva um algoritmo que:
            // Leia 4 (quatro) números;
            // Calcule o quadrado de cada um;
            // Se o valor resultante do quadrado do terceiro for >= 1000, imprima-o e finalize;
            // Caso contrário, imprima os valores lidos e seus respectivos quadrados.

            // Variáveis:

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int quadrado1 = 0;
            int quadrado2 = 0;
            int quadrado3 = 0;
            int quadrado4 = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite o 1º número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4º número:");
            num4 = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            quadrado1 = num1 * num1;
            quadrado2 = num2 * num2;
            quadrado3 = num3 * num3;
            quadrado4 = num4 * num4;

            if (quadrado3 >= 1000)
            {
                Console.WriteLine("O valor do terceiro quadrado é igual a: "+quadrado3);
                Console.WriteLine("O valor é maior que 1.000. Conta finalizada!");
            }
            else
            {
                Console.WriteLine("O quadrado do primeiro número é igual a: " +quadrado1);
                Console.WriteLine("O quadrado do segundo número é igual a: " +quadrado2);
                Console.WriteLine("O quadrado do terceiro número é igual a: " +quadrado3);
                Console.WriteLine("O quadrado do quarto número é igual a: " +quadrado4);
                Console.WriteLine("Conta finalizada!");
            }
            Console.ReadKey();
        }
    }
}
