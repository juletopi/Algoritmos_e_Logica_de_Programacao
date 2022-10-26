using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 09:

            // Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
            // critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
            // e caso positivo, que nota o aluno precisará obter para passar de ano.

            // "Média = (Prova 1 + Prova 2 + Prova 3) / 3"

            // A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

            // "Final = (Média + Exame) / 2"

            // A média final para a aprovação deve ser igual ou maior que 5,0.

            // Variáveis:
            double prova1 = 0, prova2 = 0, prova3 = 0;
            double exame_final = 0, nota_ex_final = 0;
            double media = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite a nota da prova 1:");
            prova1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nDigite a nota da prova 2:");
            prova2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nDigite a nota da prova 3:");
            prova3 = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            media = (prova1 + prova2 + prova3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("\r\nA média do aluno foi de: " +media+"pts" +"\r\nO aluno foi APROVADO!");
            }
            else
            {
                if (media <= 7)
                {
                    Console.WriteLine("\r\nO aluno está de EXAME FINAL, a média do aluno foi de: " +media+"pts\r\n" +"\r\nCaso já feito o EXAME FINAL, informe a nota tirada pelo aluno:");
                    nota_ex_final = double.Parse(Console.ReadLine());

                    exame_final = (media + nota_ex_final) / 2;
                }
                if (exame_final >= 5)
                {
                    Console.WriteLine("\r\nA média final do aluno foi de: " +exame_final+"pts" +"\r\nO aluno foi APROVADO!");
                }
                else
                {
                    Console.WriteLine("\r\nA média final do aluno foi de: " +exame_final+"pts" +"\r\nO aluno foi REPROVADO!");
                }
            }
            Console.ReadKey();
        }
    }
}