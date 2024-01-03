List<string> liguagensPogramacao = ["C#", "Java", "JavaScript"];
List<int> lisNumInteiro = new List<int>();
List<int> armazPares = new List<int>();

void MostrarLista()
{
    Console.WriteLine("A Lista contém os seguintes itens:");

    foreach (string l in liguagensPogramacao)
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

    foreach(string item in liguagensPogramacao)
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

    if( numEscolha == 0 || numEscolha > liguagensPogramacao.Count())
    {
        Console.WriteLine("Número inválido para busca");
    } else
    {
        string elemento = liguagensPogramacao[numEscolha - 1];
        Console.WriteLine($"O item escolhido foi {elemento}!");
    }
}

void MostarNumeroLista()
{
    if(lisNumInteiro.Count == 0)
    {
        Console.WriteLine("Não existe nenhum item na lista");
    } else
    {
        Console.WriteLine("A lista contém o(s) seguinte(s) número(s):");
        foreach (int num in lisNumInteiro)
        {
            Console.WriteLine(num);
        }
    }
}

void AdicionarNumeroLista()
{
    bool continuar = false;

    while(!continuar)
    { 
        Console.Write("Informe o número que deseja inserir: ");
        int numDesejado = Convert.ToInt32(Console.ReadLine()!);
        lisNumInteiro.Add(numDesejado);
        Console.Write("Deseja adicionar outro? (S/N): ");
        char adcNum = Convert.ToChar(Console.ReadLine()!.ToLower());

        if(adcNum == 'n')
        {
            continuar = true;
        }
    }
}

void SomarNumerosLista()
{
    if(lisNumInteiro.Count == 0)
    {
        Console.WriteLine("Adicione pelo menos dois números antes de usar esta opção!!!");
    } else
    {

        int totSoma = 0;

        foreach (int numero in lisNumInteiro)
        {
            totSoma += numero;
        }

        Console.WriteLine($"A soma dos números da lista é {totSoma}");
    }
}

void MostrarNumerosPares()
{
    for (int i = 0; i < lisNumInteiro.Count; i++)
    {
        if (lisNumInteiro[i] % 2 == 0) 
        {
            armazPares.Add(lisNumInteiro[i]);
        }
    }

    Console.WriteLine("Os números pares são:");
    foreach (int pares in armazPares)
    {
        Console.WriteLine(pares);
    }
}

void ExecutarPrograma()
{
    bool sair = false;

    while (!sair)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Escolha alguma das opções a seguir!");
        Console.ResetColor();
        Console.WriteLine("\n***********************************************************************************");
        Console.WriteLine("Digite 1 para mostrar uma lista programada de Bandas!");
        Console.WriteLine("Digite 2 para encontrar a posição de um elemento de uma lista programada de Bandas!");
        Console.WriteLine("Digite 3 para comparar um item de uma lista programada de Bandas!");
        Console.WriteLine("Digite 4 para adicionar números em uma lista!");
        Console.WriteLine("Digite 5 para mostrar os números da lista!");
        Console.WriteLine("Digite 6 para somar todos o números da lista!");
        Console.WriteLine("Digite 7 para achar os números pares da lista!");
        Console.WriteLine("Digite 0 para sair!");
        Console.WriteLine("***********************************************************************************");
        Console.Write("\n--> ");
        int escolha = Convert.ToInt32(Console.ReadLine()!);

        switch (escolha)
        {
            case 1:
                Console.Clear();
                MostrarLista();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 2:
                Console.Clear();
                EncontrarPorPosição();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 3:
                Console.Clear(); 
                CompararItemLista();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 4:
                Console.Clear();
                AdicionarNumeroLista();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 5:
                Console.Clear();
                MostarNumeroLista();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 6:
                Console.Clear();
                SomarNumerosLista();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 7:
                Console.Clear();
                MostrarNumerosPares();
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
            case 0:
                Console.Clear();
                Console.Write("Até uma próxima vez!!!");
                sair = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção Inválida!!!");
                Console.Write("\nAGUARDE 3 SEGUNDOS, NÃO FAÇA NADA!!!");
                Thread.Sleep(3000);
                break;
        }
    }
}

ExecutarPrograma();