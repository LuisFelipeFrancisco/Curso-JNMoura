using System;

/*
* A fisherman bought a microcomputer to control the daily yield of his work.
* Every time he brings a weight of fish greater than the established by the fishing regulation of the state of São Paulo
* (50 kilos) must pay a fine of R $ 4.00 per kilo excess.
* So, make a program that reads the weight of fish and check if there is excess.
* If there is, the program should also calculate the value of the fine that the fisherman should pay.
* In the end, the program should print the excess and the fine paid by the fisherman.
*/


namespace fisherman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double fine = 4.00;
            const double kgLimit = 50.00;

            Console.WriteLine("Enter the weight of fish: ");
            double fishWeight = double.Parse(Console.ReadLine());

            double excess = 0;
            double fineValue = 0;

            if (fishWeight > kgLimit)
            {
                excess = fishWeight - kgLimit;
                fineValue = excess * fine;
            }

            Console.WriteLine($"Excess: {excess:0.00} kg");
            Console.WriteLine($"Fine: {fineValue:C2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
