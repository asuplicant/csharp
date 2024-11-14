namespace PilaresPOO.Classes
{
    public abstract class Veiculos
    {
        public string? Marca;
        public string? Modelo;
        public string? Cor;
        public int Potencia;
        public int qtdPassageiro;

        public void Ligar()
        {
            Console.WriteLine($"O veículo está ligado.");
        }
        public void Desligar()
        {
            Console.WriteLine($"O veículo está desligado.");
        }
        public void Buzinar()
        {
            Console.WriteLine($"O veículo está Buzinar.");
        }
    }
}