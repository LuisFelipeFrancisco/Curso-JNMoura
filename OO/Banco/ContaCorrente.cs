using System;

namespace Banco
{
    internal class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(int numero) : base(numero)
        {
        }

        public double Tributo {get; set;}

        public void Tributar()
        {
        }
    }
}
