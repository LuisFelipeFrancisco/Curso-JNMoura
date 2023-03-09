using System;
/*
 * Faça um programa que leia 5 números inteiros informados pelo usuário e, 
 * no final, mostre o maior número e, também, a soma deles.
*/

namespace greaterAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int qtdNumbers = 5;
            int greater = int.MinValue, sum = 0, i = 1;

            #region "Mine"
            /*
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Enter the {i}º integer number:");
                int number = int.Parse(Console.ReadLine());
                
                if (number > greater)
                {
                    greater = number;
                }
                sum += number;
            }
            */
            #endregion

            do {
                Console.WriteLine($"Enter the {i}º integer number:");
                int number = int.Parse(Console.ReadLine());
                
                if (number > greater)
                {
                    greater = number;
                }
                sum += number;
                i++;
            } while (i <= qtdNumbers);

            Console.WriteLine($"The greater number is {greater}");
            Console.WriteLine($"The sum of the numbers is {sum}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
