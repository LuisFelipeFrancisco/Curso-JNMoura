using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sum of 2 numbers */

            int num1, num2, sum;

            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, sum);
            Console.WriteLine($"Sum of {num1} and {num2} is {sum}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


/* {0} is for replacing the first argument in the string and so on. 
* The arguments are passed in the order they are written in the string.
* bool is a data type that can hold only true or false. size of bool is 1 byte.
* int is a data type that can hold only integer values. size of int is 4 bytes.
* double is a data type that can hold only decimal values. size of double is 8 bytes.
* char is a data type that can hold only a single character. size of char is 2 bytes.
* string is a data type that can hold a string of characters. size of string is 2 bytes per character.
* implicit conversion is when the compiler automatically converts one data type to another.
* .Parse is a method that converts a string to a number.
* .Convert is a method that converts one data type to another.
* Template Strings are strings that can contain placeholders for variables.
*/
