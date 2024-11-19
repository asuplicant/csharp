using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;

        public string ? Titular; //valor vai ser pré preenchido

        public float saldo = 0f;

    public void Depositar(float valor)
    {
        saldo = saldo + valor;
    }

    public void Sacar(float valor)
    {
        saldo = saldo - valor;
    }

    }
}