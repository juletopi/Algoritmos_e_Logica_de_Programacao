using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saque_Bancario_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algorítimo de saldo e saque usando o conceito de "If/Else",
            // calculando o saque retirado do saldo de "R$2.000" e mostrando dois
            // possíveis resultados, baseando-se no calculo do saldo e saque.

            // Variáveis:

            double saldo = 2000;
            double saque = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite o quanto quer sacar (Somente números):");
            saque = double.Parse(Console.ReadLine());

            // Processamento e Saída de Dados:
            if (saque <= saldo)
            {
                saldo = (saldo - saque);
                Console.WriteLine("Saque efetudado com sucesso! O seu saldo agora, é de: R$" +saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, o saque não foi efetuado! Seu saldo é de: R$" +saldo);
            }
            Console.ReadKey();
        }
    }
}
