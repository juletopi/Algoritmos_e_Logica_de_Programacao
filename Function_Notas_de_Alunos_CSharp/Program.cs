
// Crie um algoritmo que registre de um aluno, suas disciplinas e
// suas notas, e então imprima-as e também imprima a média das notas.

{
    int quant_materia = 0;
    double[] notas;
    string[] nome_materia;
    double media_VM = 0;

    Console.Write("\r\n ┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
    Console.Write("\r\n │ Este programa registra quantas disciplinas com as notas e a média do(s) aluno(s) que você precisar. │");
    Console.Write("\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n");
    Console.WriteLine("\r\nDigite quantas disciplinas deseja cadastrar: ");
    quant_materia = int.Parse(Console.ReadLine());
    nome_materia = new string[quant_materia];
    notas = new double[quant_materia];

    for (int i = 0; i < quant_materia; i++)
    {
        Console.WriteLine("\r\nDigite o nome da disciplina: ");
        nome_materia[i] = Console.ReadLine();

        Console.WriteLine("Digite a nota desta disciplina: ");
        notas[i] = Convert.ToDouble(Console.ReadLine());
    }

    media_VM = media(notas);

    Console.Write("\r\n ┌─────────────┐");
    Console.Write("\r\n │ Resultados: │");
    Console.Write("\r\n └─────────────┘\r\n");

    for (int i = 0; i < quant_materia; i++)
    {
        Console.WriteLine("\r\nA nota da disciplina de " + nome_materia[i] + " é de: " + notas[i] + "pts");
    }

    Console.WriteLine("\r\nA média das notas é de:" + media_VM + "pts");
}

static double media(double[] notas)
{
    double soma = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        soma += notas[i];
    }
    double media = soma / notas.Length;
    return media;
}