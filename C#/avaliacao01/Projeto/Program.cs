using System;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> x = new Dictionary<char, char>();
            x.Add('A', '@');
            x.Add('a', '@');
            x.Add('E', '3');
            x.Add('e', '3');
            x.Add('I', '1');
            x.Add('i', '1');
            x.Add('O', '0');
            x.Add('o', '0');
            x.Add('U', '%');
            x.Add('u', '%');


            Console.Write("Digite a frase: ");
            string y = Console.ReadLine();

            string z = y;

            foreach (KeyValuePair<char, char> item in x)
            {
                z = z.Replace(item.Key, item.Value);
            }

            Console.WriteLine("Resultado: {0}", z);

            Console.ReadLine();
        }
    }
}
/*
* a) Escreva o que você entende por Dictionary.
* Dictionary -> Coleção que nos permite armazenar um conjunto de dados, onde cada dado é composto por uma chave e um valor.
ele nos permite acessar os valores através da chave. essas chaves são únicas e não podem ser repetidas, mas os valores podem ser repetidos.
usando um mapeamento de chave e valor, podemos acessar os valores através da chave.

* b) Escreva o que faz esse programa (máximo de 5 linhas - considere uma linha com aproximadamente 50 caracteres).
* O programa lê uma frase e substitui as vogais por caracteres especiais. usando um dicionário para acessar os valores correspondentes a cada vogal.

* c) Se o usuário entrar com a palavra "Amora", qual será a saída do programa. Explique como o programa chegou nesse resultado.
* A saída será: @m0r@. Ele pegou cada vogal da palavra e substituiu pelo valor correspondente no dicionário, sendo acessado pelo KeyValuePair, percorreu a string com o foreach e substituiu as vogais pela letra correspondente com o Replace.
*/

