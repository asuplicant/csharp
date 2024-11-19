string[] frutas = { "Melancia", "Carambola", "Maracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pêssego", "Banana" };

Console.WriteLine($"Sua sacola contém {frutas.Length} frutas!");

foreach (string f in frutas)
{
    Console.Write($"{f}, ");
}

Console.WriteLine();