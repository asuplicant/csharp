using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubanquinho!");
Console.WriteLine();

ContaCorrente contaLaura = new ContaCorrente();
ContaCorrente contaKaue = new ContaCorrente();

contaLaura.Titular = "Laura";
contaLaura.Depositar(1000000f);

contaKaue.Titular = "Kaue";
contaKaue.Depositar(1000000f);

Console.WriteLine($"A conta da {contaLaura.Titular} tem R$: {contaLaura.saldo}");
Console.WriteLine($"A conta do {contaKaue.Titular} tem R$: {contaKaue.saldo}");

contaKaue.Sacar(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R${contaKaue.saldo}!");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"A conta da {contaLaura.Titular} tem R$: {contaLaura.saldo}");
Console.WriteLine($"A conta do {contaKaue.Titular} tem R$: {contaKaue.saldo}");
Console.WriteLine();
