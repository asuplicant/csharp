

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
|           Vitória Time 1          |
+-----------------------------------+
");

}
else if (placarA < placarB)
{
    Console.WriteLine(@"
+-----------------------------------+
|           Vitória Time 1          |
+-----------------------------------+
");
}
else
{
    Console.WriteLine(@"
+--------------------------------+
|             EMPATE             |
+--------------------------------+
");
}


/*Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.*/



int equilatero = 3;
int isoceles = 2;
int escaleno = 3;
int resultado;

Console.WriteLine("Qual são as medidas do seu triângulo?");
resultado = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (resultado >= equilatero)
{
    Console.WriteLine("Triângulo Equilátero");

}
else if (resultado <= isoceles)
{
    Console.WriteLine("Triângulo Isóceles");
}
else
{
    Console.WriteLine("Seu triângulo pode ser ou escaleno ou isóceles");
}

