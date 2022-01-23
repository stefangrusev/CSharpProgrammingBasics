using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double grapeSqm = double.Parse(Console.ReadLine());
            double neccesaryWine = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double harvestedGrape = area * grapeSqm;
            double grapeWine = harvestedGrape * 0.40;
            double producedWine= grapeWine/ 2.5;
            double differenceWine = Math.Abs(neccesaryWine - producedWine);
            
            if (producedWine < neccesaryWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(differenceWine)} liters wine needed.");
            }
            else
            {
                double wineEmployee = differenceWine / employees;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(differenceWine)} liters left -> {Math.Ceiling(wineEmployee)} liters per person.");
            }
        }
    }
}
