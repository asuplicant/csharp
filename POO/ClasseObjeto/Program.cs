//Importando as classes de dentro da pasta Classes
using ClasseObjeto.Classes;


Console.Clear(); // limpa tela
Console.WriteLine($"** Bem vindo ao Programa ZooSharp! **");
Console.WriteLine(); // pula linha


//Cria o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Yumi";
cachorro.Especie = "Doméstico";
cachorro.Raca = "Shihtzu";
cachorro.cor = "Preto, marrom e branco";
cachorro.idade = 9;

Console.WriteLine($"Nome da cachorrinha: {cachorro.nome}");
Console.WriteLine($"Espécie da {cachorro.nome}: {cachorro.Especie}");
Console.WriteLine($"Raça da {cachorro.nome}: {cachorro.Raca}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
//Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");

Console.WriteLine($"");

Animal gato = new Animal();

gato.nome = "Ami";
gato.Especie = "Doméstico";
gato.Raca = "Siamês";
gato.cor = "Bege";
gato.idade = 5;

Console.WriteLine($"Nome da gatinha: {gato.nome}");
Console.WriteLine($"Espécie da {gato.nome}: {gato.Especie}");
Console.WriteLine($"Raça da gatinha {gato.nome}: {gato.Raca}");
Console.WriteLine($"Cor da {gato.nome}: {gato.cor}");
//Console.WriteLine($"Idade do {Ave.nome}: {Ave.idade}");

Console.WriteLine($"");

cachorro.FazerBarulho("Au au");
Console.WriteLine($"A idade da {cachorro.nome} é {cachorro.idade}");

cachorro.Envelhecer();
Console.WriteLine($"A nova idade da {cachorro.nome} é {cachorro.idade}!");

Console.WriteLine($"");

gato.FazerBarulho("Miau Miau");
Console.WriteLine($"A idade da {gato.nome} é {gato.idade}");

gato.Envelhecer();
Console.WriteLine($"A nova idade da {gato.nome} é {gato.idade}!");
