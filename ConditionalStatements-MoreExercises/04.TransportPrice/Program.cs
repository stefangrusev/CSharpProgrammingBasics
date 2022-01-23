using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (km >= 100)
            {
                double moneyTrain = km * 0.06;
                Console.WriteLine($"{moneyTrain:F2}");
            }
            else if (km >= 20 && km < 100)
            {
                double moneyForBus = km * 0.09;
                Console.WriteLine($"{moneyForBus:F2}");
            }
            else
            {
                double moneyTaxiNight = km * 0.9 + 0.70;
                double moneyTaxiDay = km * 0.79 + 0.70;
                Console.WriteLine(time == "night" ? $"{moneyTaxiNight:F2}"
                                                   :$"{moneyTaxiDay:F2}");
            }
        }
    }
}
