using System;
using System.Collections.Generic;


namespace lottery2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a dictionary to store the players and their investments
            var players = new Dictionary<string, double>();

            double prizePool;
            double totalInvestment = 0;
            int numberOfPlayers;

            Console.WriteLine("Enter the number of players: ");
            numberOfPlayers = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the prize pool: ");
            prizePool = double.Parse(Console.ReadLine());

            // Reading the investments of each player
            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName;
                double playerInvestment;

                Console.WriteLine("Enter the name of the player: ");
                playerName = Console.ReadLine();

                Console.WriteLine("Enter the investment of the player: ");
                playerInvestment = double.Parse(Console.ReadLine());

                players.Add(playerName, playerInvestment);

                totalInvestment += playerInvestment;
            }

            Console.WriteLine($"\nThe prize pool is {prizePool:C}");

            Console.WriteLine($"\nThe total investment is {totalInvestment:C}\n");

            foreach (var player in players)
            {
                double playerPrize;

                playerPrize = (player.Value / totalInvestment) * prizePool;

                Console.WriteLine($"The prize of {player.Key} is {playerPrize:C}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
