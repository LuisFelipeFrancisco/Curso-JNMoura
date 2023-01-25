using System;

/* Make a program that receives a password and tests if it is equal to 904087.
* If the password is correct write "Access granted",
* otherwise, write the message "You don't have access to the system".
*/

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string password = "904087";

            Console.WriteLine("Enter the password: ");
            string userPassword = Console.ReadLine();

            if (userPassword == password)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("You don't have access to the system");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

/* Conditional statements are used to perform different actions based on different conditions.
* If the condition is true, the code inside the if block is executed.
* Const is a keyword that is used to declare a constant variable.
*/
