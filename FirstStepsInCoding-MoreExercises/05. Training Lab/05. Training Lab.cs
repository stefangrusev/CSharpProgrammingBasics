using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lCm = length * 100.0;
            double wCm = width * 100.0;

            double workingWidth = wCm - 100;
            double desks = workingWidth / 70;
            int desksRow = (int)desks;

            double rows = lCm / 120;
            int intRows = (int)rows;
            int workingPlaces = (intRows * desksRow) -3;

            Console.WriteLine( workingPlaces);

        }
    }
}
