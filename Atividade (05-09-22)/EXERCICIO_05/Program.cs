using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 05:

            // A Secretaria de Meio Ambiente que controla o índice de poluição mantém 3 grupos
            // de indústrias que são altamente poluentes do meio ambiente. O índice de poluição aceitável
            // varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1º grupo são intimadas
            // a suspenderem suas atividades, se o índice crescer para 0,4 as industrias do 1º e 2º
            // grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os
            // grupos devem ser notificados a paralisarem suas atividades. Algoritmo que leia o índice
            // de poluição medido e emita a notificação adequada aos diferentes grupos de empresas.

            // Variáveis:

            double poluição = 0.00;

            // Entrada de Dados:
            Console.WriteLine("Informe o nível de poluição (formato 0.0):");
            poluição = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (poluição == 0.3)
            {
                Console.WriteLine("O 1º grupo de indústrias deve suspender as suas atividades!");
            }
            else if (poluição == 0.4)
            {
                Console.WriteLine("O 1º e o 2º grupo de indústrias devem suspender as suas atividades!");
            }
            else if (poluição >= 0.5)
            {
                Console.WriteLine("Todos os grupos de indústrias devem suspender as suas atividades!");
            }
            else
            {
                Console.WriteLine("Nenhum dos grupos de indústrias deve suspender as suas atividades.");
            }
            Console.ReadKey();
        }
    }
}