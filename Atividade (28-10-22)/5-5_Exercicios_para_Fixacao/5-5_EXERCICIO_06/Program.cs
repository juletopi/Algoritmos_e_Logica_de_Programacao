using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 06:

            // Elabore um algoritmo que encontre a mediana de uma sequência de números inteiros,
            // fornecida pelo usuário (número inicial e final), utilizando uma estrutura de repetição.
            // Por exemplo, a mediana da sequência "1, 2, 3, 4, e 5" é 3 e
            // a da sequência "2, 3, 4, 5, 6, 7, 8, 9" é (5 + 6) ÷ 2 = 5,5.
            // Como sugestão utilize a variável "i" para o número inicial e "j"
            // para com final, realizando operações de incremento decremento.

            // Variáveis:
            double num_inicial = 0, num_final = 0;
            double mediana;
            double i = 0;
            List<double> num = new List<double>();

            // Entrada de Dados:
            Console.WriteLine("Digite o seu número inicial:");
            num_inicial =  double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nDigite o seu número final:");
            num_final = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            
            for (i = num_inicial; i <= num_final; i++)
            {
                num.Add(i);
            }
            if (num.Count % 2 == 0)
            {
                mediana = (num[(num.Count / 2) - 1] / 2);
            }
            else
            {
                mediana = num[(num.Count / 2)];
            }
            Console.WriteLine("\r\nA mediana da sua sequência é: " +mediana +"\r\nConta finalizada!");
            Console.ReadKey();
        }
    }
}