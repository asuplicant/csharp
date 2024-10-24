int qntmulher = 0;
int qnthomem = 0;
int qntGostaEsportes = 0;
int qntNaoGostaEsportes = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite 'F' para Feminino ou 'M' para Masculino:");
    string sexo = Console.ReadLine();

    if (sexo == "F")
    {
        qntmulher++;
    }
    else if (sexo == "M")
    {
        qnthomem++;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite 'F' ou 'M'.");
        i--; 
        continue; 
    }

    Console.WriteLine("Você gosta de esportes? Digite 'S' para Sim ou 'N' para Não:");
    string gostaEsportes = Console.ReadLine();

    if (gostaEsportes == "S")
    {
        qntGostaEsportes++;
    }
    else if (gostaEsportes == "N")
    {
        qntNaoGostaEsportes++;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite 'S' ou 'N'.");
        i--; 
    }
}

Console.WriteLine($"Total de Mulheres: {qntmulher}");
Console.WriteLine($"Total de Homens: {qnthomem}");
Console.WriteLine($"Total que gostam de esportes: {qntGostaEsportes}");
Console.WriteLine($"Total que não gostam de esportes: {qntNaoGostaEsportes}");