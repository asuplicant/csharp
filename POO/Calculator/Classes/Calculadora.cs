namespace Calculator.Classes
{
    public class Calculadora
    {
        // Propriedades
        public float n1;
        public float n2;

        // Métodos
        public void Somar(float n1, float n2)
        {
            float resultado = n1 + n2;
            Console.WriteLine($"Resultado da Soma: {resultado}");
        }

        public void Subtrair(float n1, float n2)
        {
            float resultado = n1 - n2;
            Console.WriteLine($"Resultado da Subtração: {resultado}");
        }

        public void Multiplicar(float n1, float n2)
        {
            float resultado = n1 * n2;
            Console.WriteLine($"Resultado da Multiplicação: {resultado}");
        }

        public void Dividir(float n1, float n2)
        {
            if (n2 != 0)
            {
                float resultado = n1 / n2;
                Console.WriteLine($"Resultado da Divisão: {resultado}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida, tente novamente.");
            }
        }
    }
}
