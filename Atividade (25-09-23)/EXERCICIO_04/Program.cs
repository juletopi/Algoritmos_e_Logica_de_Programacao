using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Construa um algoritmo que verifique se um dado número é divisível por outro,
            // sendo que ambos devem ser fornecidos pelo usuário, usando a passagem
            // de parâmetros formais, com a exibição do resultado no programa principal.

            Console.Write("\r\n ┌────────────────────────┐");
            Console.Write("\r\n │ Verificação de Divisão │");
            Console.Write("\r\n └────────────────────────┘\r\n");

            bool continuar = true;

            do
            {
                // Obtendo os números pelo usuário.
                Console.Write("\r\n Digite o primeiro número: ");
                int numA = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Digite o segundo número: ");
                int numB = Convert.ToInt32(Console.ReadLine());

                bool divisivel = VerificarNumerosDivisiveis(numA, numB);

                Console.WriteLine("\r\n -----------------------------------------");

                Console.Write("\r\n ┌───────────┐");
                Console.Write("\r\n │ Resultado │");
                Console.Write("\r\n └───────────┘\r\n");

                // Imprimindo se os números são divisíveis ou não a partir da função "VerificarNumerosDivisiveis"
                if (divisivel)
                {
                    int resultadoDivisao = numA / numB;
                    Console.WriteLine(string.Format("\r\n {0} é divisível por {1}.", numA, numB));
                    Console.WriteLine(" Pois o resultado dessa divisão é: " + resultadoDivisao);
                }
                else
                {
                    int resultadoDivisao = numA / numB;
                    Console.WriteLine(string.Format("\r\n {0} não é divisível por {1}.", numA, numB));
                    Console.WriteLine(" Pois o resultado dessa divisão é: " + resultadoDivisao);
                }

                Console.WriteLine("\r\n -----------------------------------------\r\n");

                Console.Write(" Deseja fazer outra operação? (s/n): ");
                char escolha = Console.ReadLine()[0];
                continuar = (escolha ==  's' || escolha == 'S');

            } while (continuar);

            Console.WriteLine(" Saindo do programa... Desligando agora, até mais!");
            Console.ReadKey();
        }
        // Função: Verificando se o primeiro número é divisível pelo segundo número
        static bool VerificarNumerosDivisiveis(int num1, int num2)
        {
            return num1 % num2 == 0;
        }
    }
}