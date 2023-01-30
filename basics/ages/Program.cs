using System;
/*
 * Faça um programa que solicite a idade de várias pessoas e mostre:
 * • Total de pessoas com menos de 21 anos.
 * • Total de pessoas com mais de 50 anos.
 * • A média de idade das pessoas.
 * Importante: O programa termina quando a idade informada for -1 (Menos 1)
*/
namespace ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, under21 = 0, over50 = 0, sum = 0, count = 0;
            double average;
            Console.WriteLine("Enter the age: ");
            age = int.Parse(Console.ReadLine());
            while (age != -1)
            {
                if (age < 21)
                {
                    under21++;
                }
                if (age > 50)
                {
                    over50++;
                }
                sum += age;
                count++;
                Console.WriteLine("Enter the age: ");
                age = int.Parse(Console.ReadLine());
            }
            average = (double)sum / count;
            Console.WriteLine("Total of people under 21 years old: " + under21);
            Console.WriteLine("Total of people over 50 years old: " + over50);
            Console.WriteLine("The average of the ages is: " + average);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
