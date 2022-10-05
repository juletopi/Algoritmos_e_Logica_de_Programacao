using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Escolha_de_Cursos_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo que dê um leque de opções de cursos para o usuário
            // escolher e qual turma ele poderá ingressar, usando o conceito
            // de "Switch-Case" na linguagem CSharp.

            // Variáveis:

            string curso;
            string turma;
            int opc_curso = 0;
            int opc_turma = 0;

            // Entrada de Dados: (Curso)

            Console.WriteLine("O que você deseja cursar?");
            Console.WriteLine("Digite 1 para o curso de ADS");
            Console.WriteLine("Digite 2 para o curso de Química");
            Console.WriteLine("Digite 3 para o curso de Florestas");
            opc_curso = Convert.ToInt32(Console.ReadLine());

            // Processamento e Saída de Dados: (Curso)
            switch (opc_curso)
            {
                case 1:
                    curso = "ADS";
                break;

                case 2:
                    curso = "Química";
                break;

                case 3:
                    curso = "Florestas";
                break;

                default:
                    Console.WriteLine("Você digitou alguma informação errada!!!");
                    curso = "Sem curso definido.";
                break;
            }

            // Entrada de Dados: (Turma)

            Console.WriteLine("Ok, agora qual turma você deseja ingressar?");
            Console.WriteLine("Digite 1 para o curso de A");
            Console.WriteLine("Digite 2 para o curso de B");
            Console.WriteLine("Digite 3 para o curso de C");
            opc_turma = Convert.ToInt32(Console.ReadLine());

            // Processamento e Saída de Dados: (Turma)
            switch (opc_turma)
            {
                case 1:
                    turma = "A";
                break;

                case 2:
                    turma = "B";
                break;

                case 3:
                    turma = "C";
                break;

                default:
                    Console.WriteLine("Você digitou alguma informação errada!!!");
                turma = "Sem turma definida.";
                break;
            }
            Console.WriteLine("O seu curso escolhido é: " +curso);
            Console.WriteLine("A sua turma escolhida é: " +turma);
            Console.ReadKey();
        }
    }
}
