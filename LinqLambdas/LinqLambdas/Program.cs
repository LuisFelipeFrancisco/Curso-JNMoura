using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqLambdas
{
    internal class Program
    {
        class Fruta // Criando a classe Fruta
        {
            public Fruta(string nome, string cor, int preco)
            {
                Nome = nome;
                Cor = cor;
                Preco = preco;
            }
            public string Nome { get; set; }
            public string Cor { get; set; }
            public int Preco { get; set; }
        }

        static IList<Fruta> criaDados() // Criando uma lista de frutas
        {
            return new List<Fruta>()
          {
             new Fruta("maça", "verde", 7),
             new Fruta("laranja", "laranja", 10),
             new Fruta("uva", "verde", 4),
             new Fruta("figo", "marrom", 12),
             new Fruta("ameixa", "vermelha", 2),
             new Fruta("banana", "amarela", 10),
             new Fruta("morango", "vermelha", 7)
           };
        }

        static void Main(string[] args)
        {
            IList<Fruta> fonteDados = criaDados(); // Instanciando a lista de frutas

            //IEnumerable<string> resultado1 = from e in fonteDados where e.Cor == "vermelha" select e.Nome; // Filtrando por fruta vermelha

            IEnumerable<string> resultado1 = fonteDados.Where(e => e.Cor == "vermelha").Select(e => e.Nome); // Filtrando por fruta vermelha

            Console.WriteLine("Filtrar por fruta - vermelha"); // Imprimindo o resultado
            foreach (string str in resultado1)
            {
                Console.WriteLine("Fruta {0}", str); 
            }

            IEnumerable<Fruta> resultado2 = from e in fonteDados
                                            where e.Preco > 5
                                            select e; // Filtrando por preco > 5

            Console.WriteLine("\nFiltrar para preco > 5");
            foreach (Fruta Fruta in resultado2)
            {
                Console.WriteLine("Fruta {0}", Fruta.Nome); 
            }

            IEnumerable<string> resultado3 = from e in fonteDados
                                             where e.Cor == "verde"
                                             && e.Preco > 5
                                             select e.Nome; // Filtrando por fruta verde e preco > 5

            Console.WriteLine("\nFiltrar para Fruta verde e preco > 5");
            foreach (string str in resultado3)
            {
                Console.WriteLine("Fruta {0}", str);
            }

            Console.WriteLine("\nOperação concluída. Pressione Enter");
            Console.ReadLine();
        }
    }
}
