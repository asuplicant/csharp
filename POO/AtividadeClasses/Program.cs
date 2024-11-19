using AtividadeClasse;

Console.WriteLine($"*** Bem a VeiculoSharp ***");

Carros carros1 = new Carros();

Console.WriteLine($"Olá! Por gentileza, indique a marca do seu carro: ");
carros1.marca = Console.ReadLine();

Console.WriteLine($"Agora, por favor, indique o modelo do carro: ");
carros1.modelo = Console.ReadLine();

Console.WriteLine($"Indique a cor do carro");
carros1.cor = Console.ReadLine();

Console.WriteLine($"Indique a potencia do carro");
carros1.potencia = Console.ReadLine();

Console.WriteLine($"Indique a Quantidade de portas do carro");
carros1.qtdPortas = int.Parse(Console.ReadLine());

Console.WriteLine($"");

Console.WriteLine($"A marca do carro é: {carros1.marca}");
Console.WriteLine($"O modelo do {carros1.marca}: {carros1.modelo}");
Console.WriteLine($"Cor do {carros1.marca}: {carros1.cor}");
Console.WriteLine($"Potência do {carros1.marca}: {carros1.potencia}");
Console.WriteLine($"Quantidade de portas do {carros1.marca}: {carros1.qtdPortas}");

carros1.Acelerar();
carros1.Ligar();
carros1.Desligar();
carros1.Freiar();
