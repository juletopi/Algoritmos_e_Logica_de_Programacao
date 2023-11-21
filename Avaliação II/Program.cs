using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace Avaliacao_de_Algoritmos_2
{
    internal class Program
    {
        class Cliente
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public double Peso { get; set; }
            public char Sexo { get; set; }
            public int Idade { get; set; }
            public List<(string Aparelho, double Calorias)> ProgramaExercicios { get; set; }
        }

        // Lista que irá armazenar os clientes da academia
        static List<Cliente> listaClientes = new List<Cliente>();

        static void Main(string[] args)
        {
            // Avaliacão de Algoritmos 2

            // 1) Cleverson, tem uma academia em Ji-Paraná. Crie uma Lista contendo o cadastro dos clientes da Academia:
            // código, nome, peso, sexo, idade.Cada Cliente tem um programa de exercícios com nome do aparelho e calorias gastas. (05pts)

            // 2) Faça o encadeamento da lista simplesmente encadeada. (10pts)

            // 3) Faça uma função que calcule a quantas calorias foram gastas. (05pts)

            // 4) Mostre todos elementos da lista e salve em arquivo. (08pts)

            // 5) Faça duas consultas, onde o usuário pode consultar por nome ou código. (05pts)

            // 6) Faça um menu, onde o usuário possa escolher quais opções ele vai usar:
            // adicionar na lista, consultar por nome ou código, lista todos
            // elementos dalista com a quantidade de cadastros na lista. (10pts)

            // Definição da classe Cliente para armazenar informações dos clientes

            // -------------------------------------------------------------------------------

            Console.Write("\r\n ┌──────────────────────────────────┐");
            Console.Write("\r\n │ Cadastro de Clientes da Academia │");
            Console.Write("\r\n └──────────────────────────────────┘\r\n");

            while (true)
            {
                // Menu de opções para o usuário
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\r\n 1. Adicionar cliente");
                Console.WriteLine(" 2. Consultar por nome");
                Console.WriteLine(" 3. Consultar por código");
                Console.WriteLine(" 4. Listar todos os clientes");
                Console.WriteLine(" 5. Calcular calorias totais");
                Console.WriteLine(" 6. Salvar em arquivo");
                Console.WriteLine(" 7. Sair");
                Console.WriteLine("\r\n -----------------------------------------");
                Console.Write("\r\n Digite o número da opção desejada: ");

                int opcEscolha = Convert.ToInt32(Console.ReadLine());

                switch (opcEscolha)
                {
                    case 1:
                        AdicionarCliente(); // Nº1, Adicionar cliente na lista
                        break;
                    case 2:
                        ConsultarPorNome(); // Nº2, Consultar cliente por nome
                        break;
                    case 3:
                        ConsultarPorCodigo(); // Nº3, Consultar cliente por código
                        break;
                    case 4:
                        ListarClientes(); // Nº4, Listar todos os clientes
                        break;
                    case 5:
                        CalcularCaloriasTotais(); // Nº5, Calcular calorias totais
                        break;
                    case 6:
                        SalvarEmArquivo(); // Nº6, Salvar dados em arquivo
                        break;
                    case 7:
                        Console.WriteLine("Saindo do programa... Desligando agora, até mais!");
                        return;
                    default:
                        Console.WriteLine("\r\n Opção inválida! Por favor, selecione uma opção válida.");
                        break;
                }
            }
        }

        // Nº1, Adicionar cliente na lista
        static void AdicionarCliente()
        {
            Cliente novoCliente = new Cliente();

            Console.Write("\r\n Digite o código do cliente: ");
            novoCliente.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite o nome do cliente: ");
            novoCliente.Nome = Console.ReadLine();

            Console.Write(" Digite o peso do cliente: ");
            novoCliente.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite o sexo do cliente (M/F): ");
            novoCliente.Sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write(" Digite a idade do cliente: ");
            novoCliente.Idade = Convert.ToInt32(Console.ReadLine());

            novoCliente.ProgramaExercicios = new List<(string, double)>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($" Digite o nome do aparelho {i + 1}: ");
                string nomeAparelho = Console.ReadLine();

                Console.Write($" Digite as calorias gastas no aparelho {i + 1}: ");
                double calorias = Convert.ToDouble(Console.ReadLine());

                novoCliente.ProgramaExercicios.Add((nomeAparelho, calorias));
            }

            listaClientes.Add(novoCliente);
            Console.WriteLine(" Cliente adicionado com sucesso!");
        }

        // Nº2, Consultar cliente por nome
        static void ConsultarPorNome()
        {
            Console.Write("\r\n Digite o nome do cliente para consulta: ");
            string nomeConsulta = Console.ReadLine();

            var resultado = listaClientes.FindAll(cliente => cliente.Nome.ToLower().Contains(nomeConsulta.ToLower()));

            if (resultado.Count > 0)
            {
                Console.WriteLine("\r\n Resultados da consulta por nome:");
                foreach (var cliente in resultado)
                {
                    MostrarDetalhesCliente(cliente);
                }
            }
            else
            {
                Console.WriteLine("\r\n Nenhum cliente encontrado com esse nome.");
            }
        }

        // Nº3, Consultar cliente por código
        static void ConsultarPorCodigo()
        {
            Console.Write("\r\n Digite o código do cliente para consulta: ");
            int codigoConsulta = Convert.ToInt32(Console.ReadLine());

            var resultado = listaClientes.Find(cliente => cliente.Codigo == codigoConsulta);

            if (resultado != null)
            {
                Console.WriteLine("\r\n Resultado da consulta por código:");
                MostrarDetalhesCliente(resultado);
            }
            else
            {
                Console.WriteLine("\r\n Nenhum cliente encontrado com esse código.");
            }
        }

        // Nº4, Listar todos os clientes
        static void ListarClientes()
        {
            Console.WriteLine("\r\n Lista de todos os clientes:");

            foreach (var cliente in listaClientes)
            {
                MostrarDetalhesCliente(cliente);
            }
        }

        // Nº5, Calcular calorias totais
        static void CalcularCaloriasTotais()
        {
            double caloriasTotais = 0;

            foreach (var cliente in listaClientes)
            {
                foreach (var exercicio in cliente.ProgramaExercicios)
                {
                    caloriasTotais += exercicio.Calorias;
                }
            }

            Console.WriteLine($"\r\n Calorias totais gastas na academia: {caloriasTotais}");
        }

        // Função Auxiliar: Mostrar detalhes de um cliente
        static void MostrarDetalhesCliente(Cliente cliente)
        {
            Console.WriteLine("\r\n ----------------------------------------- \r\n");
            Console.WriteLine($" Código: {cliente.Codigo}");
            Console.WriteLine($" Nome: {cliente.Nome}");
            Console.WriteLine($" Peso: {cliente.Peso}");
            Console.WriteLine($" Sexo: {cliente.Sexo}");
            Console.WriteLine($" Idade: {cliente.Idade}");
            Console.WriteLine(" Programa de Exercícios:");

            foreach (var exercicio in cliente.ProgramaExercicios)
            {
                Console.WriteLine($" - Aparelho: {exercicio.Item1}, Calorias: {exercicio.Item2}");
            }
        }

        // Nº6, Salvar dados em arquivo
        static void SalvarEmArquivo()
        {
            using (StreamWriter writer = new StreamWriter("clientes.txt"))
            {
                foreach (var cliente in listaClientes)
                {
                    writer.WriteLine($"Código: {cliente.Codigo}, Nome: {cliente.Nome}, Peso: {cliente.Peso}, Sexo: {cliente.Sexo}, Idade: {cliente.Idade}");

                    foreach (var exercicio in cliente.ProgramaExercicios)
                    {
                        writer.WriteLine($"Aparelho: {exercicio.Item1}, Calorias: {exercicio.Item2}");
                    }

                    writer.WriteLine("-----------------------------------------");
                }
            }

            Console.WriteLine("Dados dos clientes salvos em arquivo (clientes.txt).");

            Console.ReadKey();
        }
    }
}