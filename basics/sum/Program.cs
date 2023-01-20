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
            /* Sum os all the numbers in a range */
            int sum = 0;
            int start = 1;
            int end = 5;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all the numbers from {0} to {1} is {2}", start, end, sum);
            Console.ReadLine();
        }
    }
}
