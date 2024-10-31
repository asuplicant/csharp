// Importando as classes de dentro da pasta Classes
using ClasseObjeto.Classes;

// Cria o objeto/variável animal
Animal cachorro = new Animal();

cachorro.nome = "Yumi";
cachorro.raca = "Shih Tzu";
cachorro.cor = "Marrom, preto e branco";
cachorro.idade = 9;

Console.WriteLine($"Nome da cachorrinha: {cachorro.nome}");
Console.WriteLine($"Raça da cachorrinha: {cachorro.raca}");
Console.WriteLine($"Cor da cachorrinha: {cachorro.cor}");
Console.WriteLine($"Idade da cachorrinha: {cachorro.idade}");

Animal gato = new Animal();

Console.WriteLine("");

gato.nome = "Ami";
gato.raca = "Siamês";
gato.cor = "Marrom";
gato.idade = 10;

Console.WriteLine($"Nome da gatinha: {gato.nome}");
Console.WriteLine($"Raça da gatinha: {gato.raca}");
Console.WriteLine($"Cor da gatinha: {gato.cor}");
Console.WriteLine($"Idade da gatinha: {gato.idade}");


