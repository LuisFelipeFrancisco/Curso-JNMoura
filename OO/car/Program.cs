using System;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car civic = new Car(4, "Civic", "Honda", 2019, "Black", 0);
            Car celta = new Car(4, "Celta", "Chevrolet", 2018, "White", 0);
            Car fusca = new Car(2, "Fusca", "Volkswagen", 1970, "Yellow", 0);

            civic.ShowInfo();
            celta.ShowInfo();
            fusca.ShowInfo();

            civic.Accelerate();
            civic.Accelerate();

            celta.Accelerate();
            celta.Accelerate();
            celta.Accelerate();

            fusca.Accelerate();

            civic.ShowInfo();
            celta.ShowInfo();
            fusca.ShowInfo();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
