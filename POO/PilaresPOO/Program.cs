// herança
// abstração
// encapsulamento
// polimorfismo

using PilaresPOO.Classes.Aprendizagem;

Pessoa aura = new Pessoa();
aura.Nome = "Aura";

Console.WriteLine($"{aura.Nome} Nasceu com {aura.Idade} anos");
Console.WriteLine("");

Professor sam = new Professor(123321);
sam.Nome = "Samanta";
sam.Idade = 22;

Aluno auraAmaral = new Aluno();

auraAmaral.Nome = "Aura";
auraAmaral.Idade = 17;
auraAmaral.Matricula = 12345678;
auraAmaral.Curso = "Dev";
auraAmaral.Media = 10;

// Exibição de Dados
Console.WriteLine($"Professor: {sam.Nome}");
Console.WriteLine($"Identificação do Professor: {sam.NIF}");

Console.WriteLine();

Console.WriteLine($"Nome do aluno: {auraAmaral.Nome}");
Console.WriteLine($"Idade: {auraAmaral.Idade}");
Console.WriteLine($"Matrícula: {auraAmaral.Matricula}");
Console.WriteLine($"Nome do curso: {auraAmaral.Curso}");
Console.WriteLine($"Média: {auraAmaral.Media}");

//---------------------------------------------------------------------

Console.WriteLine($@"O seu avião: ");
Aviao asas = new Aviao();
asas.Marca = "Airbus";
asas.Modelo = "Aeródinos";
asas.Cor = "Branco";
asas.Potencia = 156;
asas.Portas = 6;

Console.WriteLine($@"O seu carro: ");
Carro fusca = new Fusca();
asas.Marca = "Airbus";
asas.Modelo = "Aeródinos";
asas.Cor = "Branco";
asas.Potencia = 156;
asas.Portas = 6;
