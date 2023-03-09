using System;
/*
* a) Altere a classe ItemOrcamento considerando a utilização de propriedades.
*/

namespace Loja
{
    internal class ItemOrcamento
    {
        public string descricao { get; }
        public decimal valor { get; }

        public ItemOrcamento(string descricao, decimal valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}