using System;

namespace _04ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalSales = 0;
            double averageRating = 0;

            for (int i = 0; i < n; i++)
            {
                double possibleSales = int.Parse(Console.ReadLine());
                int rating = int.Parse(possibleSales.ToString()[possibleSales.ToString().Length - 1].ToString());
                possibleSales = int.Parse(possibleSales.ToString().Substring(0, possibleSales.ToString().Length - 1));

                averageRating += rating;

                if (rating == 2)
                {
                    possibleSales = 0;
                }
                else if (rating == 3)
                {
                    possibleSales *= 0.50;
                }
                else if (rating == 4)
                {
                    possibleSales *= 0.70;
                }
                else if (rating == 5)
                {
                    possibleSales *= 0.85;
                }

                totalSales += possibleSales;
               
            }

            averageRating /= n;

            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{averageRating:f2}");

        }
    }
}
