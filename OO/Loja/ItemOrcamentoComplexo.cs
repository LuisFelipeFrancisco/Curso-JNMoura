using System;
/*
* b) Crie uma classe denominada ItemOrcamentoComplexo que estenda a classe ItemOrcamento.
*/

namespace Loja
{
    internal class ItemOrcamentoComplexo : ItemOrcamento
    {
        public ItemOrcamentoComplexo(string descricao, decimal valor) : base(descricao, valor)
        {
        }
    }
}
