using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Dadas as temperaturas que foram registradas, diariamente, durante uma semana,
            // deseja-se determinar em quantos dias desta semana a temperatura esteve acima da média.
            // A solução para este problema envolve os seguintes passos:

            // a) Obter os valores das temperaturas.
            // b) Calcular a média desses valores.
            // c) Verificar quantos deles são maiores que a média.

            int diasDaSemana = 7;
            double[] temperaturas = new double[diasDaSemana];

            Console.Write("\r\n ┌──────────────────────────────────┐");
            Console.Write("\r\n │ Registro de temperaturas semanal │");
            Console.Write("\r\n └──────────────────────────────────┘\r\n");
            Console.WriteLine("");

            // a) Obter os valores das temperaturas.
            for (int i = 0; i < diasDaSemana; i++)
            {
                Console.Write(" Digite a temperatura (ºC) registrada no dia " + (i + 1) + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // b) Calcular a média desses valores.
            double somaTemperaturas = 0;
            for (int i = 0; i < diasDaSemana; i++)
            {
                somaTemperaturas += temperaturas[i];
            }
            double media = somaTemperaturas / diasDaSemana;

            // c) Verificar quantos deles são maiores que a média.
            int diasAcimaDaMedia = 0;
            for (int i = 0; i < diasDaSemana; i++)
            {
                if (temperaturas[i] > media)
                {
                    diasAcimaDaMedia++;
                }
            }
            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────┐");
            Console.Write("\r\n │ Resultados │");
            Console.Write("\r\n └────────────┘\r\n");

            Console.WriteLine("\r\n A média das temperaturas é: " + media.ToString("F2") + "ºC");
            Console.WriteLine(" Em " + diasAcimaDaMedia + " dias, a temperatura esteve acima da média.");

            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}