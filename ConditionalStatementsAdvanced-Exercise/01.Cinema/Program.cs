using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColums = int.Parse(Console.ReadLine());
    
            double income = 0;

            if (typeProjection == "Premiere")
            {
                income = numberOfRows * numberOfColums * 12.00;
            }
            else if (typeProjection == "Normal")
            {
                income = numberOfRows * numberOfColums * 7.50;
            }
            else if (typeProjection == "Discount")
            {
                income = numberOfRows * numberOfColums * 5.00;
            }
    
            Console.WriteLine($"{income:F2}");
            Console.WriteLine("leva");

        }
    }
}
