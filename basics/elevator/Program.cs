using System;
/*
 * Faça um programa que mostre se um elevador pode entrar em funcionamento ou não. 
 * Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador 
 * e o número de pessoas que desejam utilizá-lo. 
 * Depois, solicitar o peso de cada pessoa e, no final, exibir se o elevador poderá entrar em funcionamento ou não.
 * Caso a soma dos pesos das pessoas for maior que o peso máximo suportado pelo elevador, 
 * ele não poderá entrar em funcionamento.
 */

namespace elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxWeight, totalWeight = 0;
            int people;
            Console.WriteLine("Enter the maximum weight supported by the elevator: ");
            maxWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of people who want to use the elevator: ");
            people = int.Parse(Console.ReadLine());

            for (int i = 1; i <= people; i++)
            {
                Console.WriteLine($"Enter the weight of the {i}º person: ");
                totalWeight += double.Parse(Console.ReadLine());
            }
            if (totalWeight <= maxWeight)
            {
                Console.WriteLine("The elevator can operate");
            }
            else
            {
                Console.WriteLine("The elevator cannot operate");
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
