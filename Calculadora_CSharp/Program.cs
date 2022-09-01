using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algorítimo que receba três valores, após a leitura
            // calcule e mostre o resultado de: Soma, Subtração,
            // Multiplicação, Divisão e Divisão com o Resto.

            // Variáveis:

            // 1. Valores:
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;

            // 2. Soma:
            double soma = 0;

            // 3. Subtração:
            double sub = 0;

            // 4. Multiplicação:
            double multi = 0;

            // 5. Divisão:
            double div = 0;

            // 6. Resto da Divisão:
            double resto = 0;

            // Entrada de Dados:
            Console.WriteLine("Digite o primeiro número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            n3 = double.Parse(Console.ReadLine());

            // Processamento:
            soma = n1 + n2 + n3;
            sub = n1 - n2 - n3;
            multi = n1 * n2 * n3;
            div = (n1 / n2 / n3);
            resto = (n1 % n2 % n3);

            // Saída dos Dados:
            Console.WriteLine("Os números somados são: " + soma);
            Console.WriteLine("Os números subtraídos são: " + sub);
            Console.WriteLine("Os números multiplicados são: " + multi);
            Console.WriteLine("Os números divididos são: " + div);
            Console.WriteLine("O resto dos números divididos são: " + resto);
            Console.WriteLine("Pressione ENTER para ver as médias aritméticas:");
            Console.ReadKey();

            // Agora acrescente um algorítimo que mostre a
            // média ponderada (soma: maior - menor /2) e
            // a média aritmética (soma / quantidade das somas).

            //Média Ponderada:
            double media_p = 0;
            double valor1 = 0;

            media_p = soma - valor1;

            Console.WriteLine("A média ponderada da soma dos valores é: " + media_p / 2);
            Console.ReadKey();

            //Média Aritmética:
            double media_a = 0;

            media_a = soma;

            Console.WriteLine("A média aritmética da soma dos valores é: " + media_a / 3);
            Console.ReadKey();
        }
    }
}