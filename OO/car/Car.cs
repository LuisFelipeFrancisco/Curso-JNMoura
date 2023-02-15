using System;

namespace car
{
    internal class Car
    {
        private int DoorsQuantity { get; set; }
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private int Year { get; set; }
        private string Color { get; set; }
        private int Speed { get; set; }

        public Car(int doorsQuantity, string model, string manufacturer, int year, string color, int speed)
        {
            DoorsQuantity = doorsQuantity;
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Color = color;
            Speed = speed;
        }

        public void Accelerate()
        {
            Console.WriteLine($"The {Color} {Model} from {Manufacturer} is accelerating... Vrum vrum!");
            Speed += 10;
        }

        public void Brake()
        {
            Speed -= 10;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"The {Color} {Model} from {Manufacturer} has {DoorsQuantity} doors and is going {Speed} km/h.");
        }
    }
}
