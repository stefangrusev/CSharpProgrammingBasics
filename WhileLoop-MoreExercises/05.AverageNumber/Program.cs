using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double number = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"{sum / n:F2}");
        }
    }
}