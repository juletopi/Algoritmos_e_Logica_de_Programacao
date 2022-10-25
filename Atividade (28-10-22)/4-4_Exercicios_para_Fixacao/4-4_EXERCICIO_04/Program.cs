using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 04:

            // Uma empresa concederá um reajuste de 8,75% no próximo mês. Elabore um algoritmo que, a partir
            // dos dados inseridos pelo usuário, calcule o salário reajustado de um funcionário, exibindo
            // como resultado, o seu nome, o valor do seu salário atual e o valor do salário reajustado.

            // Variáveis:
            double salario = 0, salario_total = 0;
            double reajuste = 8.75, reajuste_valor = 0;
            string nome;

            // Entrada de Dados:
            Console.WriteLine("Digite o nome do funcionário:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário:");
            salario = double.Parse(Console.ReadLine());

            // Processamento:
            reajuste_valor = (reajuste / 100) * salario;
            salario_total = reajuste_valor + salario;

            // Saída dos Dados:
            Console.WriteLine("O salário do funcionário é: R$" +salario);
            Console.WriteLine("O salário do funcionário, pós reajuste de 8,75%, é: R$" +salario_total);
            Console.ReadLine();
        }
    }
}