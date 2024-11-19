using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        // nome, idade e matrícula
        public string nome { get; set; }
        public int idade { get; set; }
        public string matricula { get; set; }

        public Aluno(string no, int id, string mat)
        {
            nome = no;
            idade = id;
            matricula = mat;
        }

        public void ExibirDadosAlunos()
        {
            Console.WriteLine(@$"
            Nome: {nome}
            Idade: {idade}
            Matricula: {matricula}
            ");
        }
    }
}

//-----------------------------------------------------------------------------------------------