// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a quantidade do lado 1 do triângulo");
int lado1Triangulo = int.Parse (Console.ReadLine());

Console.WriteLine("Informe a quantidade do lado 2 do triângulo");
int lado2Triangulo = int.Parse (Console.ReadLine());

Console.WriteLine("Informe a quantidade do lado 3 do triângulo");
int lado3Triangulo = int.Parse (Console.ReadLine());


if (lado1Triangulo == lado2Triangulo && lado2Triangulo == lado3Triangulo ) 
{
Console.WriteLine($"O triângulo é equilátero");
}

else if(lado1Triangulo == lado2Triangulo || lado1Triangulo == lado3Triangulo || lado2Triangulo==lado3Triangulo)
{
    Console.WriteLine($"O triângulo é isóceles");
}

else
{
    Console.WriteLine("O triângulo é escaleno");
}
