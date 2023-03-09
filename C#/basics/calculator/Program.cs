using System;

/*
* Program to read two integers 
* show the sum, subtraction, multiplication, division and the remainder of the division between them.
*/

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, sub, mult, rest;
            double div;

            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = (double)num1 / num2; // (double) is used to convert the result to double
            rest = num1 % num2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mult);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Rest: " + rest);

            Console.ReadKey();
        }
    }
}
