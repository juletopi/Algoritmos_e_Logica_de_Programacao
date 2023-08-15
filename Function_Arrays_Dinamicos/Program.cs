using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Vetores_Multidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo feito em aula (Cadastro de notas de alunos)

            int x = 0;

            Console.WriteLine("Digite quantos alunos deseja cadastrar: "); // <-- Pedindo para o usuário especificar 
            x = int.Parse(Console.ReadLine());                                 // quantos cadastros deseja fazer

            string[] nomeAluno;
            double[] nota1 = new double[x];
            double[] nota2 = new double[x];
            double[] media = new double[x];
            nomeAluno = new string[x];

            for (int i = 0; i < nomeAluno.Length; i++) // <-- É aplicado o "Lenght" somente a variáveis do tipo vetor/array
            {
                Console.WriteLine("\r\nDigite o nome do aluno: ");
                nomeAluno[i] = Console.ReadLine();

                Console.WriteLine("Digite a 1º nota do aluno: ");
                nota1[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a 2º nota do aluno: ");
                nota2[i] = Convert.ToDouble(Console.ReadLine());

                media[i] = (nota1[i] + nota2[i]) / 2;
            }

            Console.Clear();

            for (int i = 0; i < nomeAluno.Length; i++) // <-- Criando um efeito de "Calculando...", exibindo a mensagem 
            {                                              // "Calculando notas", seguida por 50 pontos impressos em uma
                Console.Write("\r\n Calculando notas");    // linha, com um atraso de 30 milissegundos entre cada ponto
                for (int j = 0; j < 50; j++)
                {
                    System.Threading.Thread.Sleep(30);
                    Console.Write(".");
                }

                Console.WriteLine();
                Console.WriteLine("\r\n-----------------------------------------");

                Console.WriteLine(" As notas do aluno " + nomeAluno[i] + " são: ");
                Console.WriteLine(" Nota 1: " + nota1[i] + "pts");
                Console.WriteLine(" Nota 2: " + nota2[i] + "pts");
                Console.WriteLine("\r\n A sua média é: " + media[i] + "pts");

                if (media[i] >= 60)
                {
                    Console.WriteLine("\r\n Está APROVADO!");
                }
                else
                {
                    Console.WriteLine("\r\n Está REPROVADO!");
                }

                Console.WriteLine("\r\n Pressione ENTER para prosseguir...");

                Console.WriteLine("-----------------------------------------");

                Console.ReadKey();
            }
        }
    }
}