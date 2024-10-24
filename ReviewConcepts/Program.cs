// See https://aka.ms/new-console-template for more information

Console.WriteLine(@"
+------------------------------------+
|           Boas Vindas!             |
+------------------------------------+");

//mostrar esses dados cadastrados
Console.WriteLine("Olá, digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Agora, por gentileza, digite seu sobrenome: ");
string sobrenome = Console.ReadLine();


//clw

Console.WriteLine("Me diga o número do seu telefone, por gentileza: ");
string numeroTelefone = Console.ReadLine();
Console.WriteLine("Agora, informe seu CPF: ");
string CPF = Console.ReadLine();
Console.WriteLine("Agora, informe seu endereço: ");
string endereco = Console.ReadLine();
Console.WriteLine("Informe seu estado civíl: ");
string estadoCivil = Console.ReadLine();

//idade
Console.WriteLine($"Em que ano você nasceu?");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Obrigado(a)! {nome} {sobrenome} ");
Console.WriteLine($"Seu CPF é: {CPF} ");
Console.WriteLine($"Seu número de telefone é: {numeroTelefone} ");
Console.WriteLine($"Sua idade é: {idade} ");