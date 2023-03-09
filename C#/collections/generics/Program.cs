using System;
using System.Collections.Generic;


namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(10);
            int soma = numeros[0];

            for (int i = 1; i < 8; i++)
            {
                numeros.Add(numeros[i - 1] * 2);
                soma += numeros[i];
                Console.WriteLine($"Posicoes ultilizadas: {numeros.Count}");
                Console.WriteLine($"Capacidade do array:  {numeros.Capacity}");
            }

            Console.WriteLine($"O valor armazenado na 8ª posição é: {numeros[7]}");
            Console.WriteLine($"A soma de todos os valores armazenados no vetor é: {soma}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
