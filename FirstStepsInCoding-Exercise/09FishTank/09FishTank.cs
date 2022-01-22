using System;

namespace _09FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentages = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double volumeInLiters = volume / 1000;
            double area = percentages / 100.0;
            double necessaryLiters = volumeInLiters * (1 - area);

            Console.WriteLine(necessaryLiters);
        }
    }
}
