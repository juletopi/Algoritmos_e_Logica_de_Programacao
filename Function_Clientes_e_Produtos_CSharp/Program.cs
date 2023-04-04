using System.Collections.Specialized;

namespace Function_Clientes_e_Produtos_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant_cliente = 0;
            int quant_por_cliente = 0;

            Console.Write("\r\n ┌─────────────────────────────────────────────────────────────────────────────────┐");
            Console.Write("\r\n │ Este programa registra a compra de quantos produtos precisar para cada cliente. │");
            Console.Write("\r\n └─────────────────────────────────────────────────────────────────────────────────┘\r\n");
            Console.WriteLine("\r\nDigite quantas vendas deseja cadastrar: ");
            quant_cliente = Convert.ToInt32(Console.ReadLine());

            string[] nome_cliente = new string[quant_cliente];
            string[][] nome_produto = new string[quant_cliente][];
            int[] prod_cliente = new int[quant_cliente];
            double[][] valor_produto = new double[quant_cliente][];

            for (int i = 0; i < nome_cliente.Length; i++)
            {
                Console.WriteLine("\r\nDigite o nome do cliente: ");
                nome_cliente[i] = Console.ReadLine();
                Console.Write("Digite quantos produtos ele deseja comprar: ");
                quant_por_cliente = int.Parse(Console.ReadLine());

                prod_cliente[i] = quant_por_cliente;
                nome_produto[i] = new string[quant_por_cliente];
                valor_produto[i] = new double[quant_por_cliente];

                for (int j = 0; j < prod_cliente[i]; j++)
                {
                    Console.WriteLine("\r\nDigite o nome do produto: ");
                    nome_produto[i][j] = Console.ReadLine();
                    Console.WriteLine("Digite o valor do produto: ");
                    valor_produto[i][j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < nome_cliente.Length; i++)
            {;
                double soma_produto = 0.00;
                Console.Write("\r\n ┌──────────────────┐");
                Console.Write("\r\n │ Nome do Cliente: │");
                Console.Write("\r\n └──────────────────┘\r\n");
                Console.WriteLine(" " + nome_cliente[i]);
                Console.Write("\r\n ┌──────────┐");
                Console.Write("\r\n │ PRODUTOS │");
                Console.Write("\r\n └──────────┘\r\n");

                Console.Write("\r\n * --------------------------------- *");
                for (int j = 0; j < prod_cliente[i]; j++)
                {
                    Console.WriteLine("\r\n Nome do " + (j + 1) + "º produto: " + nome_produto[i][j]);
                    Console.WriteLine(" Valor do " + (j + 1) + "º produto: R$" + valor_produto[i][j].ToString("F"));

                    soma_produto = soma_produto + valor_produto[i][j];
                    Console.Write(" O valor total da compra agora é: " + soma_produto.ToString("F"));
                    Console.Write("\r\n * --------------------------------- *");
                }
            }
        }
    }
}