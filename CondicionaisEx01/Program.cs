Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|          Programa Banco XPTO          |
+---------------------------------------+
");

Console.WriteLine($"Por gentileza, digite seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Agora, digite seu gasto: ");
float gasto = float.Parse(Console.ReadLine()!);


if (gasto >= salario )
{
    Console.WriteLine($"Orçamento estourado");
}
else
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
