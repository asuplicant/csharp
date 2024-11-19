using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        protected float Saldo { get; set; }
        public string? Titular { get; set; }
        public abstract float Sacar(float valor);
        public abstract bool Depositar(float valor);

        public float getSaldo()
        {
            return Saldo;
        }

    }
}