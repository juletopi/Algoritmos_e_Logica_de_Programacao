using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Arrays_Fixos_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Vetores/Arrays
            //   Vetores, também conhecidos como arrays unidimensionais, são estruturas de dados que armazenam um 
            //   conjunto de elementos do mesmo tipo em uma sequência contígua de memória. Os elementos são acessados 
            //   por meio de um índice inteiro, que representa a posição do elemento no vetor.

            /* # Criando um vetor/array:

            double[] notas = new double[5];  <-- É adicionado um "colchete" antes da variável, indicando 
            notas[0] = 36.00;                   um novo "vetor/array", e inicializado com um tamanho de 5
            notas[1] = 38.00;                         elementos, podendo assim, armazenar 5 números.
            notas[2] = 42.00;
            notas[3] = 50.00;
            notas[4] = 39.00;

            // Outro exemplo:

            string[] nomes = new string[5];  <-- Neste novo exemplo, assim como no anterior é criado um 
            nomes[0] = Alex;                    um novo "vetor/array" com 5 elementos, só que dessa vez
            nomes[1] = Abigail;                     armazenando nomes através da variável string.
            nomes[2] = Sebastian;
            nomes[3] = Haley;
            nomes[4] = Leah;
            */

            // Exemplo feito em aula:

            int[] valores = new int[3];
            string[] nomes = new string[3];

            for (int i = 0; i < valores.Length; i++) // <-- O "for" é usado para inserir os valores dinamicamente.
            {
                Console.WriteLine("Digite valores: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Digite nomes: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("O 2º valor inserido é: " + valores[2]); // <-- Aqui é imprimido o 2º valor inserido no índice.
            Console.WriteLine("O 3º nome inserido é: " + nomes[3]); // <-- Aqui é imprimido o 3º valor inserido no índice.
            Console.WriteLine("A quantidade de nomes insiridos é: " + nomes[Length]); // <-- Ao usar o "Lenght", é imprimido o tamanho do vetor.

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Valor inserido: " + valores[2]); // <-- Aqui é imprimido todos os valores inseridos no índice.
            }

            int soma = valores[0] + valores[1] + valores[2]++;
            Console.WriteLine("Resultado da soma dos valores inseridos: " + soma); // <-- Somando os valores inseridos em cada índice.
        }
    }
}