using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estruturas de repetição: FOR e WHILE

            // As estruturas de repetição são utilizadas para processar uma coleção
            // de dados, linhas de um arquivo, registros de um banco de dados que
            // precisam ser processados por um mesmo bloco de código.

            // O FOR é mais usado para loops definidos e WHILE para loops infinitos.
            // Ou seja, com o WHILE o programa só para de "loopar" quando
            // uma condição ocorre, já o FOR possui um limite.

            // Exemplo usando o FOR: Tabuada de um número até onde o usuário quiser

            // Variáveis:
            int i, n, m;
            int resultado;

            // Entrada de Dados:
            Console.WriteLine("Defina um número para exibir a tabuada dele:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nQuantas vezes?");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // Processamento e Saída de Dados:
            for (i = 1; i <= m; i++)
            {
                resultado = n * i;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }
            Console.ReadKey();
        }
    }
}