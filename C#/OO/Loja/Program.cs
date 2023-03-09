using System;
/*
* a) Altere a classe ItemOrcamento considerando a utilização de propriedades.
* b) Crie uma classe denominada ItemOrcamentoComplexo que estenda a classe ItemOrcamento.
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento();

            ItemOrcamento item1 = new ItemOrcamento("Item 1", 100);
            ItemOrcamento item2 = new ItemOrcamento("Item 2", 200);
            ItemOrcamento item3 = new ItemOrcamento("Item 3", 300);
            ItemOrcamento item4 = new ItemOrcamento("Item 4", 400);
            ItemOrcamento item5 = new ItemOrcamento("Item 5", 500);

            Console.WriteLine($"Item 1: {item1.descricao} - {item1.valor}");
            Console.WriteLine($"Item 2: {item2.descricao} - {item2.valor}");
            Console.WriteLine($"Item 3: {item3.descricao} - {item3.valor}");
            Console.WriteLine($"Item 4: {item4.descricao} - {item4.valor}");
            Console.WriteLine($"Item 5: {item5.descricao} - {item5.valor}");
            
            ItemOrcamentoComplexo itemComplexo1 = new ItemOrcamentoComplexo("Item Complexo 1", 1000);
            ItemOrcamentoComplexo itemComplexo2 = new ItemOrcamentoComplexo("Item Complexo 2", 2000);
            ItemOrcamentoComplexo itemComplexo3 = new ItemOrcamentoComplexo("Item Complexo 3", 3000);
            ItemOrcamentoComplexo itemComplexo4 = new ItemOrcamentoComplexo("Item Complexo 4", 4000);
            ItemOrcamentoComplexo itemComplexo5 = new ItemOrcamentoComplexo("Item Complexo 5", 5000);

            Console.WriteLine($"Item Complexo 1: {itemComplexo1.descricao} - {itemComplexo1.valor}");
            Console.WriteLine($"Item Complexo 2: {itemComplexo2.descricao} - {itemComplexo2.valor}");
            Console.WriteLine($"Item Complexo 3: {itemComplexo3.descricao} - {itemComplexo3.valor}");
            Console.WriteLine($"Item Complexo 4: {itemComplexo4.descricao} - {itemComplexo4.valor}");
            Console.WriteLine($"Item Complexo 5: {itemComplexo5.descricao} - {itemComplexo5.valor}");

            orcamento.AdicionarItem(item1);
            orcamento.AdicionarItem(item2);
            orcamento.AdicionarItem(item3);
            orcamento.AdicionarItem(item4);
            orcamento.AdicionarItem(item5);

            orcamento.AdicionarItem(itemComplexo1);
            orcamento.AdicionarItem(itemComplexo2);
            orcamento.AdicionarItem(itemComplexo3);
            orcamento.AdicionarItem(itemComplexo4);
            orcamento.AdicionarItem(itemComplexo5);

            Console.WriteLine("Valor do orçamento: " + orcamento.getValor());

            Console.WriteLine($"Removendo o item {item1.descricao} - {item1.valor}");
            orcamento.RemoverItem(item1);

            Console.WriteLine($"Removendo o item {itemComplexo1.descricao} - {itemComplexo1.valor}");
            orcamento.RemoverItem(itemComplexo1);

            Console.WriteLine("Valor do orçamento: " + orcamento.getValor());

            Console.ReadKey();
        }
    }
}
