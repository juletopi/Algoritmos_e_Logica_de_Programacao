using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _5_5_EXERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 07:

            // Uma empresa de recrutamento e seleção de funcionários possui,
            // entre seus clientes, organizações em diversos ramos de atividade.
            // Para facilitar o trabalho de identificação do perfil dos candidatos
            // que se inscrevem para as vagas, a empresa optou por fazer um programa
            // de registro de alguns dados, classificado as seguintes informações:

            // - O número de candidatos do sexo feminino.
            // - O número de candidatos do sexo masculino.
            // - A idade média dos homens com experiência.
            // - A idade média das mulheres com experiência.
            // - A percentagem dos homens entre 35 e 45 anos, entre o total dos homens.
            // - A menor idade entre as mulheres que já tem experiência no serviço.
            // - O nível de escolaridade dos candidatos considerando ensino
            // fundamental, ensino médio, ensino superior, e pós-graduação.

            // Elabore um algoritmo para calcular e apresentar as informações mencionadas,
            // sendo que, a cada interação deve ser perguntado ao usuário se ele deseja
            // cadastrar outro candidato, encerrando o programa se resposta for negativa.

            // Variáveis:
            string nome, sexo, exp, option;
            int idade, escolaridade;
            int candidato_F = 0, candidato_M = 0;
            int media_exp_F = 0, media_exp_M = 0;
            int percentagem = 0, menor_idade = 0;
            int soma_1 = 0, soma_2 = 0, idade_F, idade_M;
            int edu_fund = 0, edu_medio = 0, edu_grad = 0, edu_posgrad = 0;

            // Entrada, Processamento e Saída de Dados:
            do
            {
                Console.Write("\r\n ┌────────────────────────────────────────┐");
                Console.Write("\r\n │ Bem-vindo(a) ao cadastro de candidato! │");
                Console.Write("\r\n └────────────────────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite o seu nome completo: ");
                nome = Console.ReadLine();
                Console.WriteLine("\r\nDigite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("\r\nInforme o seu sexo (F ou M): ");
                sexo = Console.ReadLine().ToUpper();
                Console.WriteLine("\r\nPossui experiência? (S ou N): ");
                exp = Console.ReadLine().ToUpper();
                Console.WriteLine("\r\nQual o seu nível de escolaridade?\r\n \r\nDigite 1 - Para Ensino Fundamental Completo \r\nDigite 2 - Para Ensino Médio Completo \r\nDigite 3 - Para Ensino Superior Completo \r\nDigite 4 - Para Pós-Graduação Completa \r\n");
                escolaridade = int.Parse(Console.ReadLine());

                if (escolaridade == 1)
                {
                    edu_fund++;
                }
                else if (escolaridade == 2)
                {
                    edu_medio++;
                }
                else if (escolaridade == 3)
                {
                    edu_grad++;
                }
                else if (escolaridade == 4)
                {
                    edu_posgrad++;
                }
                else
                {
                    Console.WriteLine("\r\nSelecione uma opção válida!");
                }

                if (sexo == "F")
                {
                    candidato_F++;
                    idade_F = idade;
                    soma_1 = soma_1 + idade_F;

                    if (sexo == "F" && exp == "S")
                    {
                        media_exp_F = soma_1 / candidato_F;

                        if (menor_idade == 0)
                        {
                            menor_idade = idade_F;
                        }
                        if (idade_F < menor_idade)
                        {
                            menor_idade = idade_F;
                        }
                    }
                }

                else
                {
                    candidato_M++;
                    idade_M = idade;
                    soma_2 = soma_2 + idade_M;

                    if (sexo == "M" && exp == "S")
                    {
                        media_exp_M = soma_2 / candidato_M;
                    }
                    if (idade_M >= 35 && idade_M <= 45)
                    {
                        percentagem += 1;
                        percentagem = (percentagem * 100) / candidato_M;
                    }
                }
                Console.Write("\r\n ┌─────────────────────────────────┐");
                Console.Write("\r\n │ Deseja realizar outro cadastro? │");
                Console.Write("\r\n └─────────────────────────────────┘\r\n");
                Console.WriteLine("\r\nDigite S para SIM ou N para NÃO... \r\n");
                option = Console.ReadLine().ToUpper();

            } while (option == "S");

            Console.Write("\r\n ┌────────────────────────────┐");
            Console.Write("\r\n │ Informações dos Candidatos │");
            Console.Write("\r\n └────────────────────────────┘\r\n");
            // O número de candidatos do sexo feminino.
            Console.WriteLine("\r\nCandidatas do sexo feminino: " +candidato_F);

            // O número de candidatos do sexo masculino.
            Console.WriteLine("Candidatos do sexo masculino: " +candidato_M);

            // A idade média dos homens com experiência.
            Console.WriteLine("Idade média dos homens com experiência: " +media_exp_M);

            // A idade média das mulheres com experiência.
            Console.WriteLine("Idade média das mulheres com experiência: " + media_exp_F);

            // A percentagem dos homens entre 35 e 45 anos, entre o total dos homens.
            Console.WriteLine("Percentagem dos homens cadastrados entre 35 e 45 anos: " +percentagem +"%");

            // A menor idade entre as mulheres que já tem experiência no serviço.
            Console.WriteLine("Menor idade entre as mulheres com experiência: " +menor_idade);

            // O nível de escolaridade dos candidatos considerando ensino
            // fundamental, ensino médio, ensino superior, e pós-graduação.
            Console.WriteLine("\r\nNível de escolaridade dos candidatos: \r\n" +edu_fund +" candidato(s) com o ensino fundamental completo \r\n" +edu_medio +" candidato(s) com o ensino médio completo \r\n" +edu_grad +" candidato(s) com ensino superior completo \r\n" +edu_posgrad +" candidato(s) com pós-graduação completa");

        Console.ReadKey();
        }
    }
}