using System;
using System.Collections.Generic;

namespace atividade01
{
    internal class Program
    {
        internal interface IDespesa
        {
        }

        public class DespesaMes : IDespesa
        {
            private int mes;
            private decimal valor;

            public DespesaMes(int mes, decimal valor)
            {
                this.mes = mes;
                this.valor = valor;
            }

            public int getMes()
            {
                return this.mes;
            }

            public decimal getValor()
            {
                return this.valor;
            }
        }
        /*
        Identifique e corrija um erro de lógica existente na classe DespesaDia.
        Resposta:
        A classe DespesaDia não precisa implementar a interface IDespesa, pois ela já herda da classe DespesaMes que já implementa a interface IDespesa.
        */
        public class DespesaDia : DespesaMes
        /* Identifique os conceitos de orientação a objeto representados pelo 
        DespesaMes e pelo IDespesa.
        Resposta: 
        O conceito de herança é representado pela classe DespesaDia que herda da classe DespesaMes.
        O conceito de interface é representado pela interface IDespesa. 
        */
        {
            private int dia;

            public DespesaDia(int dia, int mes, decimal valor) : base(mes, valor)
            {
                this.dia = dia;
            }

            public int getDia()
            {
                return this.dia;
            }
        }
        /*Construa uma classe chamada Despesa que deverá possuir um método construtor e um método chamado
        “addDespesa”. O método “addDespesa” será responsável por adicionar qualquer tipo de despesa (diária
        ou mensal) em uma lista de despesas previamente instanciada pelo construtor da classe Despesa.

        Na classe Despesa, construa um método chamado getValorTotal() que será responsável por retornar o
        valor total das despesas contidas na lista de despesas.
        */

        public class Despesa
        {
            private List<IDespesa> despesas;

            public Despesa()
            {
                despesas = new List<IDespesa>();
            }

            public void addDespesa(IDespesa despesa)
            {
                despesas.Add(despesa);
            }

            public decimal getValorTotal()
            {
                decimal total = 0;
                foreach (IDespesa despesa in despesas)
                {
                    if (despesa is DespesaDia)
                    {
                        total += ((DespesaDia)despesa).getValor();
                    }
                    else if (despesa is DespesaMes)
                    {
                        total += ((DespesaMes)despesa).getValor();
                    }
                }
                return total;
            }

            static void Main(string[] args)
            {
                Despesa despesa = new Despesa();
                despesa.addDespesa(new DespesaDia(1, 1, 100));
                despesa.addDespesa(new DespesaDia(2, 1, 200));
                despesa.addDespesa(new DespesaDia(3, 1, 300));
                despesa.addDespesa(new DespesaMes(1, 1000));
                despesa.addDespesa(new DespesaMes(2, 2000));
                despesa.addDespesa(new DespesaMes(3, 3000));
                Console.WriteLine("Valor total: " + despesa.getValorTotal());
                Console.ReadKey();
            }
        }
    }
}
