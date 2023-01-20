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
            double player1, player2, player3, prize, total, share1, share2, share3;

            Console.WriteLine("Enter the value invested by player 1: ");
            player1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value invested by player 2: ");
            player2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value invested by player 3: ");
            player3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of the prize: ");
            prize = double.Parse(Console.ReadLine());

            total = player1 + player2 + player3;
            share1 = (player1 / total) * prize;
            share2 = (player2 / total) * prize;
            share3 = (player3 / total) * prize;

            Console.WriteLine($"Player 1 will win {share1}");
            Console.WriteLine($"Player 2 will win {share2}");
            Console.WriteLine($"Player 3 will win {share3}");

            Console.ReadKey();
        }
    }
}
