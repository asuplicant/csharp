using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public string Raca;
        public string Especie;
        public string cor;
        public string nome;
        public int idade = 0;


    // visibilidade tipoRetorno nomeDoMetodo (parametros)
    public void FazerBarulho(string barulho)
    {
        Console.WriteLine($"Som do animal: {barulho}");
    }
    
    public void Envelhecer()
    {
        idade = idade + 1;  
    }
    }

}
