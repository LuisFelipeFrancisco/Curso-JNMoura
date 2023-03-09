using System;

/*
 * Crie uma classe chamada Jogador contendo os atributos nome (string), rg (string), cpf
 * (string) e endereco (string) e:
 * a) Crie um método construtor para essa classe inicializado os atributos para "" (vazio).
 * b) Instancie o objeto zequinha do tipo jogador e atribua valores para seus atributos.
 * c) Instancie o objeto mariazinha do tipo jogador e atribua valores para seus atributos.
 * PROJETO : JOGADOR
*/
namespace jogador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador zequinha = new Jogador();
            zequinha.Nome = "Zequinha";
            zequinha.RG = "00.000.000-0";
            zequinha.CPF = "000.000.000-00";
            zequinha.Endereco = "Rua 1";
            Console.WriteLine("Nome: " + zequinha.Nome);
            Console.WriteLine("RG: " + zequinha.RG);
            Console.WriteLine("CPF: " + zequinha.CPF);
            Console.WriteLine("Endereço: " + zequinha.Endereco);
            Jogador mariazinha = new Jogador();
            mariazinha.Nome = "Mariazinha";
            mariazinha.RG = "11.111.111-1";
            mariazinha.CPF = "111.111.111-11";
            mariazinha.Endereco = "Rua 2";
            Console.WriteLine("Nome: " + mariazinha.Nome);
            Console.WriteLine("RG: " + mariazinha.RG);
            Console.WriteLine("CPF: " + mariazinha.CPF);
            Console.WriteLine("Endereço: " + mariazinha.Endereco);
            Console.ReadKey();
        }
    }
}
