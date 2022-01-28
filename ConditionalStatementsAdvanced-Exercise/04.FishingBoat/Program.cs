using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;

            switch (seasson)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }

            if (fishermen <= 6)
            {
                price -= price * 0.1;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                price -= price * 0.15;
            }
            else if (fishermen >= 12)
            {
                price -= price * 0.25;
            }

            if (fishermen % 2 == 0 && seasson != "Autumn")
            {
                price -= price * 0.05;
            }


            Console.WriteLine(budget>=price ? $"Yes! You have {budget-price:F2} leva left."
                                            : $"Not enough money! You need {price-budget:F2} leva.");
        }

    }
}

