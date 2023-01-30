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
            int num1, num2, num3, num4, num5, sum, greater;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number: ");
            num5 = int.Parse(Console.ReadLine());

            sum = num1 + num2 + num3 + num4 + num5;
            greater = num1;

            if (num2 > greater)
            {
                greater = num2;
            }
            if (num3 > greater)
            {
                greater = num3;
            }
            if (num4 > greater)
            {
                greater = num4;
            }
            if (num5 > greater)
            {
                greater = num5;
            }

            Console.WriteLine("The greater number is: " + greater);
            Console.WriteLine("The sum of the numbers is: " + sum);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
