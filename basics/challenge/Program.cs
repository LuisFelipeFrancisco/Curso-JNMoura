using System;

namespace challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, z = 0; // n and z are initialized to 0

            z = 1 + n++; // z equals 1, n equals 1 (n++ is executed after the statement)

            Console.WriteLine($"Valor de z = {z++}"); // prints 1, z = 2 (z++ is evaluated after the statement)

            n = 0; // n is reset to 0

            z = 1 + ++n; // z equals 2, n equals 1 (++n is executed before the statement)

            Console.WriteLine($"Valor de z = {++z}"); // prints 3, z = 3 (++z is executed before the statement)

            int a = 0, b = 0; // a and b are initialized to 0
            a = 2 + a++ + ++b *2;
            Console.WriteLine($"Valor de a = {a}"); // prints 4 because its been superscribed by the last statement

            int c = 0;
            c = 2 + c++ + ++c *2; // Still don't know why this is 6 :)
            Console.WriteLine($"Valor de c = {c}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

/*
* The ++ operator can be used as a prefix or a postfix operator.
* When used as a prefix operator, the value of the operand is incremented before the expression is evaluated.
* When used as a postfix operator, the value of the operand is incremented after the expression is evaluated.
* The -- operator can be used as a prefix or a postfix operator.
* When used as a prefix operator, the value of the operand is decremented before the expression is evaluated.
* When used as a postfix operator, the value of the operand is decremented after the expression is evaluated.
*/