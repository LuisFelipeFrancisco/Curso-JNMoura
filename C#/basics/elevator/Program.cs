using System;
/*
 * Faça um programa que mostre se um elevador pode entrar em funcionamento ou não. 
 * Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador 
 * e o número de pessoas que desejam utilizá-lo. 
 * Depois, solicitar o peso de cada pessoa e, no final, exibir se o elevador poderá entrar em funcionamento ou não.
 * Caso a soma dos pesos das pessoas for maior que o peso máximo suportado pelo elevador, 
 * ele não poderá entrar em funcionamento.
 * @ Tratar os erros de entrada de dados.
 */

namespace elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxWeight, totalWeight = 0;
            int people;
            bool canConvert;
            
            do {
                Console.WriteLine("Enter the maximum weight of the elevator: ");
                canConvert = double.TryParse(Console.ReadLine(), out maxWeight);
            } while (maxWeight <= 0 || !canConvert);

            do {
                Console.WriteLine("Enter the number of people: ");
                canConvert = int.TryParse(Console.ReadLine(), out people);
            } while (people <= 0 || !canConvert);

            for (int i = 1; i <= people; i++)
            {
                double weight;
                do {
                    Console.WriteLine($"Enter the weight of the {i}º person: ");
                    canConvert = double.TryParse(Console.ReadLine(), out weight);
                } while (weight <= 0 || !canConvert);
                totalWeight += weight;
            }

            if (totalWeight <= maxWeight)
            {
                Console.WriteLine("The elevator can enter into operation.");
            }
            else
            {
                Console.WriteLine("The elevator cannot enter into operation.");
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
