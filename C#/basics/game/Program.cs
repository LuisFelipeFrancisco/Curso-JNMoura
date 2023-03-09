using System;
/*
 * Faça um programa que receba um golpe que um personagem deve executar. 
 * O programa deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. 
 * Para identificar os golpes, utilize 3 teclas: c (chute), s (soco) e m (magia), onde: 
 * chute vale 2 pontos, soco 4 pontos e magia 10 pontos. 
 * No final, o programa deve exibir para o usuário o número e a pontuação obtida por cada tipo de golpe, 
 * bem como a pontuação total do usuário.
 */

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kick = 0, punch = 0, magic = 0, totalPoints = 0;
            char key;

            do
            {
                Console.WriteLine("Enter the type of hit (c - kick, s - punch, m - magic) or any other key to exit:");
                key = char.Parse(Console.ReadLine().ToLower()); // Para evitar problemas com letras maiúsculas
                switch (key)
                {
                    case 'c':
                        kick++;
                        totalPoints += 2;
                        break;
                    case 's':
                        punch++;
                        totalPoints += 4;
                        break;
                    case 'm':
                        magic++;
                        totalPoints += 10;
                        break;
                }
            } while (key == 'c' || key == 's' || key == 'm'); 
            Console.WriteLine($"The total number of kicks is {kick} and the total number of points is {kick * 2}");
            Console.WriteLine($"The total number of punches is {punch} and the total number of points is {punch * 4}");
            Console.WriteLine($"The total number of magic is {magic} and the total number of points is {magic * 10}");
            Console.WriteLine($"The total number of points is {totalPoints}");
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
