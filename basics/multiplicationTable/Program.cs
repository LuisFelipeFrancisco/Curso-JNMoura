using System;
/*
 * Faça um programa que leia um número inteiro e imprima sua tabuada. (for - while - do/while) 
 * 0 a 10
 */

namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            /* for loop */
            Console.WriteLine("For loop:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i:00} = {number * i:00}");
            }

            /* while loop */
            Console.WriteLine("While loop:");
            var j = 0;
            while (j <= 10)
            {
                Console.WriteLine($"{number} x {j:00} = {number * j:00}");
                j++;
            }

            /* do while loop */
            Console.WriteLine("Do while loop:");
            var k = 0;
            do
            {
                Console.WriteLine($"{number} x {k:00} = {number * k:00}");
                k++;
            } while (k <= 10);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
