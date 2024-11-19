namespace Construtores.Classes
{
    public class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string cor { get; set; }

        // metódos construtores (metódos que não retornam valores)
        public Veiculo(string ma, string md, int an, string cr){
          marca = ma;
          modelo = md;
          cor = cr;
          ano = an;
        }

        public void ExibirDadosVeiculos()
        {
            Console.WriteLine(@$"
            Marca: {marca}
            Modelo: {modelo}
            Ano: {ano}
            Cor: {cor}
            ");
        }
    }
}