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
            // EXERCÍCIO 06:

            // Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
            // Infantil A = 5 a 7 anos.
            // Infantil B = 8 a 11 anos.
            // Juvenil A = 12 a 13 anos.
            // Juvenil B = 14 a 17 anos.
            // Adultos = Maiores de 18 anos.

            // Variáveis:

            int idade = 0;

            // Entrada de Dados:
            Console.WriteLine("Bem vindo a classificação de nadadores!");
            Console.WriteLine("As categorias são: Infantil A (5-7 anos), Infantil B (8-11 anos),");
            Console.WriteLine("Juvenil A (12-13 anos), Juvenil B (14-17 anos) e Adultos (+18 anos).");
            Console.WriteLine("Informe a idade do(a) nadador(a):");
            idade = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O(A) nadador(a) se qualifica na categoria Infantil A!");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O(A) nadador(a) se qualifica na categoria Infantil B!");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("O(A) nadador(a) se qualifica na categoria Juvenil A!");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O(A) nadador(a) se qualifica na categoria Juvenil B!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("O(A) nadador(a) se qualifica na categoria de Adultos!");
            }
            else
            {
                Console.WriteLine("Desculpe, esta é uma idade muito jovem para participar da classificação :(");
            }
            Console.ReadKey();
        }
    }
}
