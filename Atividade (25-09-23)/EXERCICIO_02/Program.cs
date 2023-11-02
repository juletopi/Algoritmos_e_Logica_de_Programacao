using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_02
{
    internal class Program
    {
        static int[,] matriz; // Declarando a matriz no escopo 'Main'
        static void Main(string[] args)
        {
            // 2. Escreva um algoritmo para:

            // a) Preencher uma matriz A.
            // b) Ordenar os elementos da matriz A.
            // c) Gerar uma matriz somente com os números pares da matriz A.
            // d) Gerar uma matriz somente com os números múltiplos de 5.
            // e) Criar um menu para acessar os itens anteriores no programa principal.

            Console.Write("\r\n ┌─────────────────────────┐");
            Console.Write("\r\n │ Manipulação de Matrizes │");
            Console.Write("\r\n └─────────────────────────┘\r\n");

            while (true)
            {
                // Menu de opções para o usuário
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\r\n Menu:");
                Console.WriteLine("\r\n 1. Preencher Matriz");
                Console.WriteLine(" 2. Ordenar Matriz");
                Console.WriteLine(" 3. Gerar Matriz com Números Pares");
                Console.WriteLine(" 4. Gerar Matriz com Múltiplos de 5");
                Console.WriteLine(" 5. Sair");
                Console.WriteLine("\r\n -----------------------------------------");
                Console.Write("\r\n Digite o nº da opção desejada: ");


                int opcEscolha = Convert.ToInt32(Console.ReadLine());

                switch (opcEscolha)
                {
                    case 1:
                        // Opção 1 - Preencher a matriz
                        Console.Write("\r\n Digite o número de linhas da matriz: ");
                        int numeroLinhas = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Digite o número de colunas da matriz: ");
                        int numeroColunas = Convert.ToInt32(Console.ReadLine());

                        matriz = PreencherMatriz(numeroLinhas, numeroColunas);
                        Console.WriteLine("\r\n Matriz preenchida!");
                        break;
                    case 2:
                        // Opção 2 - Ordenar a matriz
                        if (matriz != null)
                        {
                            OrdenarMatriz(matriz);
                            Console.WriteLine("\r\n Matriz ordenada: ");
                            ImprimirMatriz(matriz);
                        }
                        else
                        {
                            Console.WriteLine("\r\n Por favor, preencha a matriz primeiro!");
                        }
                        break;
                    case 3:
                        // Opção 3 - Gerar matriz com números pares
                        if (matriz != null)
                        {
                            int[,] matrizPares = FiltrarPares(matriz);
                            Console.WriteLine("\r\n Matriz com números pares: ");
                            ImprimirMatriz(matrizPares);
                        }
                        else
                        {
                            Console.WriteLine("\r\n Por favor, preencha a matriz primeiro!");
                        }
                        break;
                    case 4:
                        // Opção 4 - Gerar matriz com múltiplos de 5
                        if (matriz != null)
                        {
                            int[,] matrizMultiplos5 = FiltrarMultiplos5(matriz);
                            Console.WriteLine("\r\n Matriz com múltiplos de 5: ");
                            ImprimirMatriz(matrizMultiplos5);
                        }
                        else
                        {
                            Console.WriteLine("\r\n Por favor, preencha a matriz primeiro!");
                        }
                        break;
                    case 5:
                        // Opção 5 - Sair do programa
                        Console.WriteLine(" Saindo do programa... Desligando agora, até mais!");
                        return;
                    default:
                        Console.WriteLine("\r\n Opção inválida! Por favor, selecione uma opção válida.");
                    break;
                }
            }
        }

        // Função: Preencher a matriz com base no número de linhas e colunas
        static int[,] PreencherMatriz(int numeroLinhas, int numeroColunas)
        {
            int[,] matriz = new int[numeroLinhas, numeroColunas];
            Console.Write("\r\n Digite os elementos da matriz: ");
            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    Console.WriteLine(" Matriz[" + i + "][" + j + "]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz;
        }

        // Função: Ordenar os elementos da matriz
        static void OrdenarMatriz(int[,] matriz)
        {
            int numeroLinhas = matriz.GetLength(0);
            int numeroColunas = matriz.GetLength(1);
            int[] tempArray = new int[numeroLinhas * numeroColunas];

            int k = 0;
            for (int i = 0; i < numeroLinhas; i++)
            {
                for(int j = 0; j < numeroColunas; j++)
                {
                    tempArray[k++] = matriz[i, j];
                }
            }

            Array.Sort(tempArray);

            k = 0;
            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    matriz[i, j] = tempArray[k++];
                }
            }
        }

        // Função: Filtragem e retorno de uma nova matriz com apenas números pares
        static int[,] FiltrarPares(int[,] matriz)
        {
            int numeroLinhas = matriz.GetLength(0);
            int numeroColunas = matriz.GetLength(1);
            int[,] matrizPares = new int[numeroLinhas, numeroColunas];

            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        matrizPares[i, j] = matriz[i, j];
                    }
                }
            }
            return matrizPares;
        }

        // Função: Filtragem e retorno de uma nova matriz com apenas números múltiplos de 5
        static int[,] FiltrarMultiplos5(int[,] matriz)
        {
            int numeroLinhas = matriz.GetLength(0);
            int numeroColunas = matriz.GetLength(1);
            int[,] matrizMultiplos5 = new int[numeroLinhas, numeroColunas];

            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    if (matriz[i, j] % 5 == 0)
                    {
                        matrizMultiplos5[i, j] = matriz[i, j];
                    }
                }
            }
            return matrizMultiplos5;
        }

        // Função: Imprimir a matriz no console
        static void ImprimirMatriz(int[,] matriz)
        {
            int numeroLinhas = matriz.GetLength(0);
            int numeroColunas = matriz.GetLength(1);

            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}