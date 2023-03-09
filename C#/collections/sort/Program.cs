using System;
using System.Collections.Generic;

/*
 * Desenvolva um programa capaz de realizar um sorteio utilizando o intervalo de números de 1 a 60. 
 * O programa deve sortear 6 números, sem repetições, dentro deste intervalo e exibi-los para o usuário.
 */

namespace sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random roleta = new Random();
            
            #region for and if
            /*
            int [] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int numero = roleta.Next(1, 11);
                if (numeros.Contains(numero))
                {
                    Console.WriteLine("Número repetido: " + numero);
                    i--;
                }
                else
                {
                    numeros[i] = numero;
                    Console.WriteLine($"{i + 1}º número: {numero}");
                }
            }
            Console.WriteLine("Números sorteados: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */
            #endregion

            HashSet<int> numerosSorteados = new HashSet<int>();
            while (numerosSorteados.Count < 10)
            {
                int numero = roleta.Next(1, 11);
                numerosSorteados.Add(numero);
            }

            Console.WriteLine("Números sorteados: ");
            foreach (int numero in numerosSorteados)
            {
                Console.WriteLine(numero);
            }
          
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
