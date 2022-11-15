using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_EXERCICIO_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 08:

            // Para auxiliar na elaboração da folha de pagamento, uma empresa precisa de um
            // programa que calcule, para cada valor de salário fornecido, os descontos relativos
            // ao imposto de renda, à contribuição ao INSS e à mensalidade do plano de saúde
            // (utilize as tabelas 5.2 e 5.3) Como resultado, o algoritmo deve mostrar:

            // - O valor total da folha de pagamento da empresa.
            // - O salário líquido de cada funcionário.
            // - O valor total do imposto de renda que a empresa deve recolher.

            // Variáveis:
            string nome, option;
            double salario_bruto, salario_ajustado;
            double imposto_renda = 0, imposto_inss = 0, imposto_total = 0;
            double total_pag = 0;

            // Entrada, Processamento e Saída de Dados:
            do
            {
                Console.Write("\r\n ┌─────────────────────────┐");
                Console.Write("\r\n │ Cadastro de Funcionário │");
                Console.Write("\r\n └─────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite o nome completo do funcionário: ");
                nome = Console.ReadLine();
                Console.WriteLine("\r\nDigite o salário bruto do funcionário (somente números): ");
                salario_bruto = double.Parse(Console.ReadLine());

                salario_ajustado = salario_bruto;
                total_pag += salario_bruto;

                //Imposto de Renda
                if (salario_bruto >= 1903.99 && salario_bruto < 2826.66)
                {
                    imposto_renda += salario_bruto * 0.075;
                    salario_ajustado = salario_bruto - (salario_bruto * 0.075);
                }
                else if (salario_bruto >= 2826.66 && salario_bruto < 3751.06)
                {
                    imposto_renda += salario_bruto * 0.15;
                    salario_ajustado = salario_bruto - (salario_bruto * 0.15);
                }
                else if (salario_bruto >= 3751.06 && salario_bruto < 4664.68)
                {
                    imposto_renda += salario_bruto * 0.225;
                    salario_ajustado = salario_bruto - (salario_bruto * 0.225);
                }
                else if (salario_bruto > 4664.68)
                {
                    imposto_renda += salario_bruto * 0.275;
                    salario_ajustado = salario_bruto - (salario_bruto * 0.275);
                }

                //INSS
                if (salario_ajustado < 1556.95)
                {
                    imposto_inss += salario_ajustado * 0.08;
                    salario_ajustado = salario_ajustado - (salario_ajustado - 0.08);
                }
                if (salario_ajustado >= 1556.95 && salario_ajustado <2594.93)
                {
                    imposto_inss += salario_ajustado * 0.09;
                    salario_ajustado = salario_ajustado - (salario_ajustado - 0.09);
                }
                if (salario_ajustado >= 2594.93 && salario_ajustado < 5189.92)
                {
                    imposto_inss += salario_ajustado * 0.11;
                    salario_ajustado = salario_ajustado - (salario_ajustado - 0.11);
                }
                Console.WriteLine("\r\nNome do funcionário: " +nome);
                Console.WriteLine("Salário bruto do funcionário: R$" + salario_bruto.ToString("F"));
                Console.WriteLine("Salário líquido do funcionário: R$" + salario_ajustado.ToString("F"));

                imposto_total = imposto_renda + imposto_inss;

                Console.Write("\r\n ┌─────────────────────────────────┐");
                Console.Write("\r\n │ Deseja realizar outro cadastro? │");
                Console.Write("\r\n └─────────────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite S para SIM ou N para NÃO... \r\n");
                option = Console.ReadLine().ToUpper();

            } while (option == "S");

            Console.Write("\r\n ┌───────────────────────────────────────────┐");
            Console.Write("\r\n │ Programa finalizado! Os resultados são... │");
            Console.Write("\r\n └───────────────────────────────────────────┘\r\n");
            // O valor total da folha de pagamento da empresa.
            Console.WriteLine("\r\nValor total da folha de pagamento da empresa: R$" +total_pag.ToString("F"));

            // O valor total de imposto de renda que a empresa deve recolher.
            Console.WriteLine("Valor total de imposto de renda que a empresa deve recolher: R$" + imposto_renda.ToString("F"));

            // O valor total de INSS que a empresa deve recolher.
            Console.WriteLine("Valor total de INSS que a empresa deve recolher: R$" + imposto_inss.ToString("F"));

            // O valor total de impostos que a empresa deve recolher.
            Console.WriteLine("Valor total de impostos que a empresa deve recolher: R$" + imposto_total.ToString("F"));

            Console.ReadKey();
        }
    }
}