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
            // 1. Faça um cadastro de alunos, onde cada aluno tem diferentes
            // disciplinas e cada disciplina tem uma nota diferentes.

            // I) Cadastrando os alunos e a quant. de disciplinas
            Console.Write("\r\n ┌─────────────────────────────────────────┐");
            Console.Write("\r\n │ Cadastro de alunos, disciplinas e notas │");
            Console.Write("\r\n └─────────────────────────────────────────┘\r\n");
            Console.WriteLine(" ");

            Console.WriteLine(" Quantos alunos você deseja cadastrar?");
            int quantAlunos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Quantas disciplinas cada aluno tem?");
            int quantDisciplinas = Convert.ToInt32(Console.ReadLine());

            string[][] nomesAlunos = new string[quantAlunos][];
            string[][] nomesDisciplinas = new string[quantAlunos][];
            double[][] notas = new double[quantAlunos][];

            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────────────────────────────────────┐");
            Console.Write("\r\n │ Informando os dados dos alunos cadastrados │");
            Console.Write("\r\n └────────────────────────────────────────────┘\r\n");

            for (int i = 0; i < quantAlunos; i++)
            {
                Console.Write(" \r\n Digite o nome do aluno nº" + (i + 1) + ": ");
                string nomedoAluno = Console.ReadLine();
                Console.WriteLine(" ");

                // II) Iniciando as matrizes internas a partir do número de disciplinas
                nomesAlunos[i] = new string[] { nomedoAluno };
                nomesDisciplinas[i] = new string[quantDisciplinas];
                notas[i] = new double[quantDisciplinas];

                for (int j = 0; j < quantDisciplinas; j++)
                {
                    Console.Write(" Digite o nome da disciplina nº" + (j + 1) + " para o aluno " + nomedoAluno + ": ");
                    nomesDisciplinas[i][j] = Console.ReadLine();

                    Console.Write(" Digite a nota da disciplina nº" + (j + 1) + " para o aluno " + nomedoAluno + ": ");
                    notas[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // III) Imprimindo os dados dos alunos e as suas notas
            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────┐");
            Console.Write("\r\n │ Resultados │");
            Console.Write("\r\n └────────────┘\r\n");

            for (int i = 0; i < quantAlunos; i++)
            {
                Console.WriteLine(" \r\n Aluno: " + nomesAlunos[i][0]);
                Console.WriteLine(" Disciplinas e Notas: ");
                Console.WriteLine(" ");

                for (int j = 0; j < quantDisciplinas; j++)
                {
                    Console.WriteLine(" " + nomesDisciplinas[i][j] + ": " + notas[i][j] + "pts");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}