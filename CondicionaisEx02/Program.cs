﻿// See https://aka.ms/new-console-template for more information


Console.WriteLine("Qual é o placar do primeiro time?");
int placarA = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Qual é o placar do segundo time?");
int placarB = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (placarA > placarB)
{
     Console.WriteLine(@"
+-----------------------------------+
|           Vitoria time 1          |
+-----------------------------------+
");
   
} else if (placarA < placarB)
{
    Console.WriteLine(@"
+-----------------------------------+
|           Vitoria time 2          |
+-----------------------------------+
");
} else {
    Console.WriteLine(@"
+-----------------------------------+
|              EMPATE               |
+-----------------------------------+
");
}
