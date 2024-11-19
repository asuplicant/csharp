namespace PilaresPOO.Classes.Aprendizagem
{
    //Subclasse - Herda de Personagem
    public class Mago : Personagem
    {
          public override void Atacar()
        {
            Console.WriteLine($"O personagem está atacando.");
        }
    }
}