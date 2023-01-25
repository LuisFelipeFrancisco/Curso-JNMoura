using System;

/* Lottery 
* Three friends played the lottery. 
* If they win, the prize must be shared proportionally to the value that each one gave to the realization of the bet. 
* Make a program that reads how much each player invested, 
* the value of the prize, and prints how much each one would win the prize based on the value invested.
*/

namespace lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double player1, player2, player3, totalInvestment, prizePool, player1Prize, player2Prize, player3Prize;

            Console.WriteLine("Enter the value invested by the first player: ");
            player1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value invested by the second player: ");
            player2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value invested by the third player: ");
            player3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the prize pool: ");
            prizePool = double.Parse(Console.ReadLine());

            totalInvestment = player1 + player2 + player3;

            player1Prize = player1 / totalInvestment * prizePool;
            player2Prize = player2 / totalInvestment * prizePool;
            player3Prize = player3 / totalInvestment * prizePool;

            Console.WriteLine($"The first player will win R$ {player1Prize:F2}");
            Console.WriteLine($"The second player will win {player2Prize:C}");
            Console.WriteLine($"The third player will win R$ {player3Prize:0.00}");

            // Changing the locale to en-US
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // Printing the values again with the new locale
            //Console.WriteLine($"The second player will win {player2Prize:C}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

/*
* F is a format specifier that indicates that the value should be formatted as a number with a fixed-point representation.
* C is a format specifier that indicates that the value should be formatted as a currency value based on the current culture.
* 0.00 is a format specifier that indicates that the value should be formatted as a number with two decimal places.
* CurrentCulture is a property that gets or sets the CultureInfo that represents the culture used by the current thread.
*/