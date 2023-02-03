using System;
using System.Collections.Generic;

/*
 * Faça um programa que inverta uma determinada sequencia de números inteiros informada pelo usuário. 
 * Você deve utilizar as estruturas de fila e pilha em sua resolução.
 * 
 */

namespace inverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();
            
            Console.WriteLine("Digite 10 números inteiros: ");
            do 
            {
                Console.Write($"{fila.Count + 1}º número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    fila.Enqueue(numero);
                    pilha.Push(numero);
                }
                else
                {
                    Console.WriteLine("Número inválido. Digite novamente: ");
                }
            } while (fila.Count < 10);

            Console.WriteLine("Sequência original: (Fila)");
            foreach (int numero in fila)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Sequência invertida: (Pilha)");
            foreach (int numero in pilha)
            {
                Console.WriteLine(numero);

            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
