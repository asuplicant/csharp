// Console.WriteLine($"Kauê Antonio Francisco da Silva Lima dos Santos");

using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctEdu = new ContaCorrente();
ctEdu.Titular = "Eduardo Mendes da Costa";
ctEdu.Depositar(1000000f);

Console.WriteLine($"Titular da Conta: {ctEdu.Titular}");
Console.WriteLine($"Saldo inicial da Conta: {ctEdu.getSaldo()}");

float valorSacado = ctEdu.Sacar(1200f);

Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Novo saldo: R${ctEdu.getSaldo()}");