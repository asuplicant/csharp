// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

float precoProduto = 200;
float minhaCarteira = 350;

if (minhaCarteira >= precoProduto)
{
    Console.WriteLine($"Sim, você pode comprar o produto!");
+-----------------------------+
|                             |
|       Meus Parabéns!        |
|                             |
+-----------------------------+");
}
else
{
     Console.WriteLine($"Infelizmente, você não pode comprar o produto");
+-----------------------------+
|                             |
|     Não foi dessa vez.      |
|                             |
+-----------------------------+");

}

