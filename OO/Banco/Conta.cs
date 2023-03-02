using System;

namespace Banco
{
    internal class Conta
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
        }

        public Conta (int numero)
        {
            this.numero = numero;
        }

    }
}
