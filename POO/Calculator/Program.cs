using Calculator.Classes;
Console.Clear();
Console.WriteLine($"Olá, seja Bem Vindo ao Calculator!");
Console.WriteLine();

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            // Exemplos de operações
            calc.Somar(10, 5);
            calc.Subtrair(10, 5);
            calc.Multiplicar(10, 5);
            calc.Dividir(10, 5);
            calc.Dividir(10, 0);
        }
    }
}