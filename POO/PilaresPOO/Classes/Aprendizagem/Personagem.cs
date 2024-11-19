namespace PilaresPOO.Classes.Aprendizagem
{
    public class Personagem
    {
        // Criar um método ATACAR que escreva no console: O personagem
        //está atacando

        //o VIRTUAL significa que o método pode ser SOBESCRITO na classe filha/sublasse

        public virtual void Atacar()
        {
            Console.WriteLine("O personagem está atacando!");
        }
    }
}