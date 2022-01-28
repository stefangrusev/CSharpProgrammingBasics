using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int marigolds = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char ifHoliday = char.Parse(Console.ReadLine());

            double marigoldPrice = 0;
            double rosePrice = 0;
            double tulipsPrice = 0;
            double totalPrice = 0;


            switch (season)
            {
                case "Spring":
                    marigoldPrice = 2;
                    rosePrice = 4.10;
                    tulipsPrice = 2.50;

                    totalPrice = marigolds * marigoldPrice + roses * rosePrice + tulips * tulipsPrice;

                    if (ifHoliday == 'Y')
                    {
                        totalPrice *= 1.15;
                    }
                    if (tulips > 7)
                    {
                        totalPrice *= 0.95;
                    }
                    if (marigolds + roses + tulips > 20)
                    {
                        totalPrice *= 0.80;
                    }

                    break;

                case "Summer":
                    marigoldPrice = 2;
                    rosePrice = 4.10;
                    tulipsPrice = 2.50;

                    totalPrice = marigolds * marigoldPrice + roses * rosePrice + tulips * tulipsPrice;

                    if (ifHoliday == 'Y')
                    {
                        totalPrice *= 1.15;
                    }
                    if (marigolds + roses + tulips > 20)
                    {
                        totalPrice *= 0.80;
                    }

                    break;

                case "Autumn":
                    marigoldPrice = 3.75;
                    rosePrice = 4.50;
                    tulipsPrice = 4.15;

                    totalPrice = marigolds * marigoldPrice + roses * rosePrice + tulips * tulipsPrice;

                    if (ifHoliday == 'Y')
                    {
                        totalPrice *= 1.15;
                    }
                    if (marigolds + roses + tulips > 20)
                    {
                        totalPrice *= 0.80;
                    }

                    break;

                case "Winter":
                    marigoldPrice = 3.75;
                    rosePrice = 4.50;
                    tulipsPrice = 4.15;

                    totalPrice = marigolds * marigoldPrice + roses * rosePrice + tulips * tulipsPrice;

                    if (ifHoliday == 'Y')
                    {
                        totalPrice *= 1.15;
                    }
                    if (roses >= 10)
                    {
                        totalPrice *= 0.90;
                    }
                    if (marigolds + roses + tulips > 20)
                    {
                        totalPrice *= 0.80;
                    }

                    break;
            }

            double finalPrice = totalPrice + 2;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
    
}
