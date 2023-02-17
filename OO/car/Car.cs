using System;

namespace car
{
    internal class Car
    {
        private int DoorsQuantity;
        public string Model;
        public string Manufacturer;
        public int Year;
        public string Color;
        private int Speed;

        public Car()
        {
            this.DoorsQuantity = 0;
            this.Model = null;
            this.Manufacturer = null;
            this.Year = 0;
            this.Color = null;
            this.Speed = 0;
        }

        public Car(int doorsQuantity, string model, string manufacturer, int year, string color)
        {
            this.DoorsQuantity = doorsQuantity;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
            this.Color = color;
            this.Speed = 0;
        }

        public void setDoorsQuantity(int doorsQuantity)
        {
            this.DoorsQuantity = doorsQuantity;
        }

        public int getDoorsQuantity()
        {
            return this.DoorsQuantity;
        }

        public int getSpeed()
        {
            return this.Speed;
        }

        public void Accelerate()
        {
            this.Speed++;
        }

        public void Accelerate(int turbo)
        {
            this.Speed += turbo;
        }
    }
}
