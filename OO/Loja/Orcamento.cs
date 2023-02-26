using System;
using System.Collections.Generic;
/*
* c) Crie outra classe denominada Orcamento que mantenha uma lista com subitens de 
* orçamento que podem ser do tipo ItemOrcamento ou ItemOrcamentoComplexo. 
* Esta nova classe deve implementar os seguintes métodos:
* 1. Método público construtor, que deve instanciar a lista de subitens do orçamento.
* 2. Método público para adicionar um novo item ao orçamento.
* 3. Método público para remover um item do orçamento.
* 4. Método público getValor que deverá retornar o valor do orçamento, 
* calculado pela soma dos valores de todos seus itens.
*/

namespace Loja
{
    internal class Orcamento
    {
        private List<ItemOrcamento> itens;
        private decimal valor;

        public Orcamento()
        {
            this.itens = new List<ItemOrcamento>();
            this.valor = 0;
        }

        public void AdicionarItem(ItemOrcamento item)
        {
            this.itens.Add(item);
            this.valor += item.valor;
        }

        public void RemoverItem(ItemOrcamento item)
        {
            this.itens.Remove(item);
            this.valor -= item.valor;
        }

        public decimal getValor()
        {
            return this.valor;
        }
    }
}
