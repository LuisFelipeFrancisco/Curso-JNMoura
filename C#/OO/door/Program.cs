using System;


namespace door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door1 = new Door(true, "Black");

            if (!door1.isOpen())
            {
                door1.OpenDoor();
            }

            if (door1.isOpen())
            {
                door1.CloseDoor();
            }

            Console.WriteLine($"Door is open: {door1.isOpen()}");
            Console.WriteLine($"Door color: {door1.getColor()}");

            door1.PaintDoor("Red");

            Console.WriteLine($"Door is open: {door1.isOpen()}");
            Console.WriteLine($"Door color: {door1.getColor()}");

            door1.PrintDoor();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
