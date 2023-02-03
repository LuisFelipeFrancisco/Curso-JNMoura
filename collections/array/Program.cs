using System;

/*Faça um programa que construa um vetor (array) de 8 posições de números inteiros armazenando em
* sua primeira posição o valor 10, na segunda posição, o dobro do valor da primeira posição, 20,
* na terceira posição, o dobro do valor da segunda posição, 40, e assim por diante. Ao final,
* mostre o valor armazenado na 8ª posição e a soma de todos os valores armazenados no vetor.
*/
namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[8];
            numeros[0] = 10;
            double soma = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                numeros[i] = numeros[i - 1] * 2;
                soma += numeros[i];
            }
            
            Console.WriteLine($"O valor armazenado na 8ª posição é: {numeros[7]}");
            Console.WriteLine($"A soma de todos os valores armazenados no vetor é: {soma}"); // {numeros.Sum()}
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

/*
* Array é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo.
* ArrayList é uma classe que implementa a interface IList, que é uma coleção de objetos.
* List<T> é uma classe que implementa a interface IList<T>, que é uma coleção de objetos do tipo T.
* Diferença entre Array e ArrayList:
* - Array é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo.
* - ArrayList é uma classe que implementa a interface IList, que é uma coleção de objetos.
* - ArrayList é mais lento que Array.
* - ArrayList é mais fácil de usar que Array.
* - ArrayList é mais flexível que Array.
*/