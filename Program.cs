using Prework;
using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter Screen dimensions");
            Console.WriteLine("2. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PixelCalc.EnterScreenDimensions();
                    break;
                case "2":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
