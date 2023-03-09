using System;
/* 
Em uma eleição presidencial, existem quatro candidatos. Os votos são informados através de códigos.
Os códigos utilizados são:
• 1,2,3,4 votos para os respectivos candidatos;
• 5 voto nulo;
• 6 voto em branco.

Assim, escreva um programa para receber um único voto e imprima:
• Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
• Se o usuário votou nulo: "Voto nulo contabilizado..."
• Se o usuário votou em branco: "Voto branco contabilizado..."

@ Caso o usuário digite um código inválido, exiba a mensagem "Voto inválido"
*/

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Election");

            var answer = 0;

            /* do while loop */
            do
            {
                Console.WriteLine("Enter your vote: ");
                var vote = int.Parse(Console.ReadLine());

                if (vote > 0 && vote < 5)
                {
                    Console.WriteLine("Vote counted successfully...");
                }
                else if (vote == 5)
                {
                    Console.WriteLine("Null vote counted...");
                }
                else if (vote == 6)
                {
                    Console.WriteLine("Blank vote counted...");
                }
                else
                {
                    Console.WriteLine("Invalid vote");
                }

                Console.WriteLine("Do you want to continue? 1 - Yes / 2 - No");
                answer = int.Parse(Console.ReadLine());

            } while (answer == 1);

            /* while loop
            while (answer == 1)
            {
                Console.WriteLine("Enter your vote: ");
                var vote = int.Parse(Console.ReadLine());

                if (vote > 0 && vote < 5)
                {
                    Console.WriteLine("Vote counted successfully...");
                }
                else if (vote == 5)
                {
                    Console.WriteLine("Null vote counted...");
                }
                else if (vote == 6)
                {
                    Console.WriteLine("Blank vote counted...");
                }
                else
                {
                    Console.WriteLine("Invalid vote");
                }

                Console.WriteLine("Do you want to continue? 1 - Yes / 2 - No");
                answer = int.Parse(Console.ReadLine());
            }
            */
            /* for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter your vote: ");
                var vote = int.Parse(Console.ReadLine());

                if (vote > 0 && vote < 5)
                {
                    Console.WriteLine("Vote counted successfully...");
                }
                else if (vote == 5)
                {
                    Console.WriteLine("Null vote counted...");
                }
                else if (vote == 6)
                {
                    Console.WriteLine("Blank vote counted...");
                }
                else
                {
                    Console.WriteLine("Invalid vote");
                }

                Console.WriteLine("Do you want to continue? 1 - Yes / 2 - No");
                answer = int.Parse(Console.ReadLine());
            }
            */
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

/*
* do while loop is used when you want to execute a block of code at least once.
* while loop is used when you want to execute a block of code repeatedly until a given condition is satisfied.
* for loop is used when you know exactly how many times you want to loop through a block of code.
* foreach loop is used to loop through each item in a collection.
*/