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
    internal class Jogador
    {
        public string Nome { set; get; }
        public string RG { set; get; }
        public string CPF { set; get; }
        public string Endereco { set; get; }
        public Jogador()
        {
            this.Nome = "";
            this.RG = "";
            this.CPF = "";
            this.Endereco = "";
        }
    }
}
