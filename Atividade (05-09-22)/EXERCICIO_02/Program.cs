using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 02:

            // Elabore um algoritmo que leia as variáveis C e N, respectivamente "código" e "número de horas
            // trabalhadas de um operário". E calcule o salário sabendo-se que ele ganha R$10,00 por hora.
            // Quando o número de horas exceder a 50 calcule o excesso de pagamento armazenando-o na
            // variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$20,00.
            // No final do processamento imprimir o salário total e o salário excedente.

            // Variáveis:

            string C = "";
            double N = 0.00;
            double E = 0.00;
            double salário = 0;
            double salário_total = 0;
            double salário_excedente = 0;

            // Entrada de Dados:
            Console.WriteLine("Informe o nº do seu CÓDIGO de funcionário:");
            C = Console.ReadLine();
            Console.WriteLine("Agora informe o nº de HORAS trabalhadas:");
            N = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (N <= 50)
            {
                E = 0;
                salário = (N * 10);
                salário_total = (salário + E);
                Console.WriteLine("Limite excedente de carga horária semanal: 50h");
                Console.WriteLine("Você não excedeu o limite da carga horária!");
                Console.WriteLine("O seu salário por horas trabalhadas é de: R$" +salário);
                Console.WriteLine("O seu salário excedente é de: R$" +E);
                Console.WriteLine("O seu salário total é de: R$" +salário_total);
            }
            else
            {
                E = (N - 50);
                salário = (50 * 10);
                salário_excedente = (E * 20);
                salário_total = (salário + salário_excedente);
                Console.WriteLine("Limite excedente de carga horária semanal: 50h");
                Console.WriteLine("Você excedeu o limite da carga horária por: " +E);
                Console.WriteLine("O seu salário por horas trabalhadas é de: R$" +salário);
                Console.WriteLine("O seu salário excedente é de: R$" +salário_excedente);
                Console.WriteLine("O seu salário total é de: R$" + salário_total);
            }
            Console.ReadKey();
        }
    }
}
