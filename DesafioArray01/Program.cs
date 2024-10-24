﻿int[] numeros = new int[6];
int qtdPares = 0, qtdImpares = 0;


Console.WriteLine("Digite 6 números inteiros:");
for (int i = 0; i < 6; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        qtdPares++;
    }
    else
    {
        qtdImpares++;
    }
}

Console.WriteLine($"\nQuantidade de números pares: {qtdPares}");
Console.WriteLine($"Quantidade de números ímpares: {qtdImpares}");
