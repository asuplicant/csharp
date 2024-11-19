using Construtores.Classes;

Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
Veiculo carro2 = new Veiculo("Ford", "Mustang", 1995, "Preto");

carro1.marca = "Ford";
carro1.modelo = "Ka";
carro1.ano = 2000;
carro1.cor = "Vermelho";

carro2.marca = "Ford";
carro2.modelo = "Mustang";

// exibir os dados dos carros
carro1.ExibirDadosVeiculos();
carro2.ExibirDadosVeiculos();

// ---------------------------------------------------------------------------------

Jogo jogo = new Jogo("Sally Face", 2016, "Terror", 250);

jogo.nome = "Resident Evil";
jogo.lancamento = 2016;
jogo.genero = "Terror";
jogo.preco = 250;

// exibir os dados dos carros
jogo.ExibirDadosJogos();

// ---------------------------------------------------------------------------------

Aluno aluno = new Aluno("Laura", 17, "Torloni");

aluno.nome = "Laura";
aluno.idade = 17;
aluno.matricula = "Torloni";

// exibir os dados dos carros
aluno.ExibirDadosAlunos();

//---------------------------------------------------------------------------------

/*
Altere o programa jogo para que contenha os seguintes elementos:
 - Menu de opções:
 1) Cadastrar Jogo
 2) Listar Jogos
 0) Sair

 Os dados deverão ser solicitados ao usuário
 O programa deverá rodar até o usuário escolher a opção sair.
*/

//---------------------------------------------------------------------------------

//CONSTRUTORES

Aluno2 auraAmaral = new Aluno2("Aura Amaral");
auraAmaral.CPF = 123;

Aluno2 renataAmaral = new Aluno2("Renata Amaral");
renataAmaral.CPF = 456;

Console.WriteLine(auraAmaral.Nome);
Console.WriteLine(auraAmaral.CPF);

Console.WriteLine(renataAmaral.Nome);
Console.WriteLine(renataAmaral.CPF);