List<string> liguagenspogramacao = ["C#", "Java", "JavaScript"];

void MostrarLista()
{
    Console.WriteLine("A Lista contém os seguintes itens:");

    foreach (string l in liguagenspogramacao)
    {

        Console.WriteLine(l);
    }
}

void CompararItemLista()
{
    Console.Write("Escolha entre uma das Linguagens de Programação a seguir:" +
    " C# ; Java ; JavaScript. > ");
    string escolhaLinguagem = Console.ReadLine()!;

    bool encontrado = false;

    foreach(string item in liguagenspogramacao)
    {
        if (item.ToLower() == escolhaLinguagem.ToLower())
        {
            Console.WriteLine($"\nO item {escolhaLinguagem} foi encontrado!");
            encontrado = true;
            break;
        } 
    }

    if (!encontrado)
    {
        Console.WriteLine($"\nO item {escolhaLinguagem} não foi encontrado!");
    }
}

void EncontrarPorPosição()
{
    Console.Write("Digita um número (1 a 3): ");
    int numEscolha = Convert.ToInt32(Console.ReadLine());

    if( numEscolha == 0 || numEscolha > liguagenspogramacao.Count())
    {
        Console.WriteLine("Número inválido para busca");
    } else
    {
        string elemento = liguagenspogramacao[numEscolha - 1];
        Console.WriteLine($"O item escolhido foi {elemento}!");
    }
}

CompararItemLista();
Console.WriteLine("");
EncontrarPorPosição();
Console.WriteLine("");
MostrarLista();