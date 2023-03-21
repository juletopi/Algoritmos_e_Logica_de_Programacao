
// Uma função na programação é uma sequência de instruções que executa uma tarefa específica
// e pode ser chamada e reutilizada em diferentes partes do programa.

// As funções ajudam a simplificar o código porque permitem que uma tarefa complexa seja dividida em partes
// menores e mais gerenciáveis. Isso torna o código mais legível, mais fácil de entender e de manter,
// além de economizar tempo e esforço para o programador.

// Além disso, as funções também permitem que o código seja reutilizado em diferentes partes do programa,
// o que significa que não é necessário reescrever o mesmo código várias vezes. Isso economiza tempo e
// esforço, além de ajudar a garantir a consistência do código em todo o programa.

// Outra vantagem de usar funções é que elas permitem que o código seja modular e organizado em blocos
// lógicos e independentes. Isso torna o programa mais flexível e escalável, permitindo que novas
// funcionalidades sejam adicionadas sem afetar o código existente.

// Em resumo, as funções são uma parte fundamental da programação e ajudam a simplificar o código,
// tornando-o mais legível, reutilizável e organizado.

// Abaixo, temos um algoritmo de registro de produtos, usando as funções para melhor simplificar o código:

{
    int quant_prod = 0;
    double valor_total = 0;
    double[] valor_prod;
    string[] nome_prod;
    double media_VP = 0;

    Console.Write("\r\n ┌─────────────────────────────────────────────────────────────────────────────────┐");
    Console.Write("\r\n │ Este programa registra quantos produtos precisar, com o seu nome e o seu valor. │");
    Console.Write("\r\n └─────────────────────────────────────────────────────────────────────────────────┘\r\n");
    Console.WriteLine("\r\nDigite quantos produtos deseja cadastrar: ");
    quant_prod = Convert.ToInt32(Console.ReadLine());
    valor_prod = new double[quant_prod];
    nome_prod = new string[quant_prod];

    for (int i = 0; i < quant_prod; i++)
    {
        Console.WriteLine("\r\nDigite o nome do produto: ");
        nome_prod[i] = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto: ");
        valor_prod[i] = Convert.ToDouble(Console.ReadLine());
        valor_total = somar(valor_total, valor_prod[i]);
    }

    media_VP = media(valor_total, quant_prod);

    Console.Write("\r\n * --------------------------------- *");

    for (int i = 0; i < quant_prod; i++)
    {
        Console.WriteLine("\r\n Nome do " + (i+1) + "º produto: " + nome_prod[i]);
        Console.WriteLine(" Valor do " + (i + 1) + "º produto: R$" + valor_prod[i].ToString("F"));
    }

    Console.WriteLine("\r\n O valor total da compra é: R$" + valor_total.ToString("F"));
    Console.WriteLine(" A média da compra é: R$" + media_VP.ToString("F"));
    Console.Write(" * --------------------------------- *");
}

static double somar(double a, double b)
{
    double soma = 0;
    soma = a + b;
    return soma;
}

static double media(double a, int b)
{
    double media = 0.00;
    media = a / b;
    return media;
}