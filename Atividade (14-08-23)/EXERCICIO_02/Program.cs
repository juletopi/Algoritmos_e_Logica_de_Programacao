using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Crie vetores/arrays para armazenar:

            // a) As vogais do alfabeto.
            // b) As alturas de um grupo de dez pessoas.
            // c) Os nomes dos meses do ano.

            // a) As vogais do alfabeto.
            char[] vogais = new char[] {'a', 'e', 'i', 'o', 'u'};

            // b) As alturas de um grupo de dez pessoas.
            double[] alturas = new double[10];

            // c) Os nomes dos meses do ano.
            string[] meses = new string[] {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
        }
    }
}