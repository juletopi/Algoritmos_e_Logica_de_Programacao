using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Codifique um algoritmo "Histograma", que exiba um histograma da variação da
            // temperatura durante a semana. Por exemplo, se as temperaturas forem
            // 19°C, 21°C, 25°C, 22°C, 20°C, 17°C e 15°C, de domingo a sábado,
            // respectivamente, o algoritmo deve-rá exibir:

            // D: ■■■■■■■■■■■■■■■■■■■
            // S: ■■■■■■■■■■■■■■■■■■■■■
            // T: ■■■■■■■■■■■■■■■■■■■■■■■■■
            // Q: ■■■■■■■■■■■■■■■■■■■■■■
            // Q: ■■■■■■■■■■■■■■■■■■■■
            // S: ■■■■■■■■■■■■■■■■■
            // S: ■■■■■■■■■■■■■■■

            // Obs: Suponha que todas as temperaturas sejam positivas
            // e que nenhuma ultrapasse o valor de 80ºC.

            // I) Obtendo o valor das temperaturas
            double[] temperaturas = new double[7];

            Console.Write("\r\n ┌──────────────────────────────────┐");
            Console.Write("\r\n │ Registro de temperaturas semanal │");
            Console.Write("\r\n └──────────────────────────────────┘\r\n");
            Console.WriteLine("");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write(" Digite a temperatura (ºC) registrada no dia " + (i + 1) + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // II) Criando o "Histograma"
            char[] diasDaSemana = new char[] { 'D', 'S', 'T', 'Q', 'Q', 'S', 'S' };

            Console.WriteLine("\r\n -----------------------------------------");

            Console.Write("\r\n ┌────────────────────┐");
            Console.Write("\r\n │ Resultados Visuais │");
            Console.Write("\r\n └────────────────────┘\r\n");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write("\r\n " + diasDaSemana[i] + ": ");
                for (int j = 0; j < temperaturas[i]; j++)
                {
                    Console.Write("■");
                }
                Console.Write(" " + temperaturas[i].ToString("F2") + "ºC");
            }

            Console.WriteLine("");
            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
            Console.WriteLine("\r\n -----------------------------------------");

            Console.ReadKey();
        }
    }
}