using System;

namespace Banco
{
    internal interface ITributavel
    {
        double Tributo { get; set; }
        void Tributar();
    }
}
