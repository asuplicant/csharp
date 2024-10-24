string[] carros = new string[3];
int i = 0;

while (i < 3)
{
    Console.WriteLine($"Por gentileza, digite o nome do carro a ser cadastrado ({i + 1}):");
    carros[i] = Console.ReadLine()!;
    i++;
}

Console.WriteLine($"Os carros cadastrados são: {carros[0]}, {carros[1]}, {carros[2]}");