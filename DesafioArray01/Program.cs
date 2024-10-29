 int[] numeros = new int[6];
        int contadorPares = 0;
        int contadorImpares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o número para a posição {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                contadorPares++;
            }
            else
            {
                contadorImpares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {contadorPares}");
        Console.WriteLine($"Quantidade de números ímpares: {contadorImpares}");
    
    