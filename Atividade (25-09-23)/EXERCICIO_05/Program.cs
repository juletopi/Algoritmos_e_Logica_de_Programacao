using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Escreva uma função, para preencher um vetor, com 30 números inteiros sorteados aleatoriamente.
            // O vetor deverá ser retornado ao programa principal, e você deve acrescentar:

            // a) Um procedimento que recebe o vetor. Preenchido no item anterior, faz a ordenação
            // dos elementos e apresenta o resultado através de uma mensagem exibida ao usuário.

            // b) Uma função que recebe o vetor preenchido no item a e que retorna
            // a quantidade de números múltiplos de 7 que existem no conjunto.

            // c) Escreva o programa principal e faça a chamada
            // aos métodos criados nos itens a, b e c.

            Console.Write("\r\n ┌─────────────────────────────────────────┐");
            Console.Write("\r\n │ Sorteio e Análise de Números Aleatórios │");
            Console.Write("\r\n └─────────────────────────────────────────┘\r\n");

            bool continuar = true;

            do
            {
                Console.WriteLine("\r\n -----------------------------------------");

                Console.Write("\r\n ┌────────────┐");
                Console.Write("\r\n │ Resultados │");
                Console.Write("\r\n └────────────┘\r\n");

                // Chamando a função que preenche o vetor com 30 números sorteados aleatóriamente
                int[] vetor = PreencherVetor();

                // Chamando a função que ordena e exibe o vetor
                OrdenarVetor(vetor);

                // Chamando a função que conta e exibe a quantidade de números múltiplos de 7 no vetor
                int multiplos7 = ContarMultiplos7(vetor);

                Console.WriteLine(" Quantos números sorteados são múltiplos de 7?");
                Console.WriteLine(" Há '" + multiplos7 + "' números múltiplos de 7 no vetor.");

                Console.WriteLine("\r\n -----------------------------------------\r\n");

                Console.Write(" Deseja fazer outra operação? (s/n): ");
                char escolha = Console.ReadLine()[0];
                continuar = (escolha == 's' || escolha == 'S');

            } while (continuar);

            Console.WriteLine(" Saindo do programa... Desligando agora, até mais!");
            Console.ReadKey();
        }

        // Função: Preenchendo o vetor com 30 números sorteados aleatóriamente
        static int[] PreencherVetor()
        {
            Random rand = new Random();
            int[] vetor = new int[30];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 101); // <-- Números sendo sorteados de 1 a 100 aleatoriamente
            }
            return vetor;
        }

        // Função: Ordenando e exibindo o vetor
        static void OrdenarVetor(int[] vetor)
        {
            Array.Sort(vetor);
            Console.WriteLine("\r\n Números aleatórios sorteados e ordenados: \r\n");
            ImprimirVetor(vetor);
        }

        // Função: Quantificando e exibindo a quantidade de números múltiplos de 7 no vetor
        static int ContarMultiplos7(int[] vetor)
        {
            int contador = 0;
            foreach (int numero in vetor)
            {
                if (numero % 7 == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        // Função: Imprimindo o vetor para a exibição
        static void ImprimirVetor(int[] vetor)
        {
            foreach (int numero in vetor)
            {
                Console.WriteLine(numero + " ");
            }
            Console.WriteLine();
        }
    }
}