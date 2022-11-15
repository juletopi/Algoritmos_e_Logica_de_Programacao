using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 01:

            // Pedro tem 1,50m e cresce 2cm por ano, enquanto Lucas tem 1,10m e cresce 3cm por ano.
            // Elabore um algoritmo que calcule e imprima quantos anos serão necessários para que:

            // Lucas e Pedro tenham o mesmo tamanho.
            // Lucas seja maior que Pedro.

            // Variáveis:
            double alt_pedro = 150, alt_lucas = 110;
            double tempo = 0;

            // Entrada de Dados:
            Console.WriteLine("Pedro tem 1,50m e cresce 2cm por ano, enquanto Lucas tem 1,10m e cresce 3cm por ano.");
            Console.WriteLine("Quantos anos serão necessários para que...");
            Console.WriteLine("\r\n1. Lucas e Pedro tenham o mesmo tamanho?\r\n2. Lucas seja maior que Pedro?");

            // Processamento e Saída de Dados:

            while (alt_lucas != alt_pedro)
            {
                alt_pedro = alt_pedro + 2;
                alt_lucas = alt_lucas + 3;
                tempo++;
            }
            Console.WriteLine("\r\nResposta:\r\nSerá necessário que se passem " +tempo +" anos para que Lucas e Pedro tenham o mesmo tamanho.");
            Console.WriteLine("Será necessário que se passem " +(tempo + 1) +" anos para que Lucas seja maior que Pedro.");
            Console.ReadKey();
        }
    }
}