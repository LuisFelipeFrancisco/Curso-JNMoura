using System;
using System.Collections;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            numeros.Add(10);
            long soma = Convert.ToInt64(numeros[0]); // trow exception if not convert to long type (ToInt64)

            for (int i = 1; i < 8; i++)
            {
                numeros.Add((int)numeros[i - 1] * 2);
                soma += (int)numeros[i];
                Console.WriteLine($"Posicoes ultilizadas: {numeros.Count}");
                Console.WriteLine($"Capacidade do array:  {numeros.Capacity}");
            }


            Console.WriteLine($"O valor armazenado na 8ª posição é: {numeros[7]}");
            //Exibindo o TIPO do objeto armazenado na 8ª posição
            Console.WriteLine($"O tipo do objeto armazenado na 8ª posição é: {numeros[7].GetType()}");
            //Exibindo o TIPO da variável numeros
            Console.WriteLine($"O tipo da variável numeros é: {numeros.GetType()}");
            Console.WriteLine($"A soma de todos os valores armazenados no vetor é: {soma}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();        }
    }
}