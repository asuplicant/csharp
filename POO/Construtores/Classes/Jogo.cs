using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        //nome, lançamento, genero e preço
        public string nome { get; set; }
        public int lancamento { get; set; }
        public string genero { get; set; }
        public int preco { get; set; }

           public Jogo(string no, int lan, string an, int pr){
          nome = no;
          lancamento = lan;
          genero = an;
          preco = pr;
        }
        
        public void ExibirDadosJogos()
        {
            Console.WriteLine(@$"
            Nome: {nome}
            Lancamento: {lancamento}
            Genero: {genero}
            Preco: {preco}
            ");
        }
    }
}


