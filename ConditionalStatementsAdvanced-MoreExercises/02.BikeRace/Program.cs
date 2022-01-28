using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            double totalTax = 0;

            if (route == "trail")
            {
                totalTax = (juniors*5.50)+(seniors*7);
            }
            else if (route == "cross-country")
            {
                totalTax = (juniors * 8) + (seniors * 9.50);
            }
            else if (route == "downhill")
            {
                totalTax = (juniors * 12.25) + (seniors * 13.75);
            }
            else if (route == "road")
            {
                totalTax = (juniors * 20) + (seniors * 21.50);
            }

                if (juniors + seniors >= 50 && route == "cross-country")
                {
                    totalTax -= (totalTax * 0.25);
                }

            double fintalTax = totalTax * 0.95;
            Console.WriteLine($"{fintalTax:f2}");
        }
    }
}
