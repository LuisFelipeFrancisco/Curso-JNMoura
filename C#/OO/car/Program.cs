using System;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car civic = new Car(4, "Civic", "Honda", 2019, "Black");
            Car celta = new Car(4, "Celta", "Chevrolet", 2018, "White");
            Car fusca = new Car(2, "Fusca", "Volkswagen", 1970, "Yellow");

            civic.Accelerate();
            civic.Accelerate();
            civic.Accelerate();
            civic.Accelerate();

            for (int i = 0; i < 1000; i++)
            {
                civic.Accelerate();
            }

            Console.WriteLine($"Civic speed: {civic.getSpeed()}");

            celta.Accelerate(5);

            Console.WriteLine($"Celta speed: {celta.getSpeed()}");

            Console.WriteLine($"Fusca speed: {fusca.getSpeed()}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
