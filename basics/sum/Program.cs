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
            int a, b, result; // Variables declaration
            Console.WriteLine("First number: "); // Print message
            a = int.Parse(Console.ReadLine()); // Read a number from console and convert to int
            Console.WriteLine("Second number: "); // Print message 
            b = int.Parse(Console.ReadLine()); // Read a number from console and convert to int
            result = a + b; // Sum a and b and store in result
            Console.WriteLine("Result: " + result); // Print result
            Console.ReadKey(); // Wait for a key press
        }
    }
}
