using System;

namespace _03DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double depositPercent = double.Parse(Console.ReadLine());
            double depositMain = depositSum * (depositPercent / 100.0);
            double months = depositMain / 12;
            double total = depositSum + depositMonths * months;
            Console.WriteLine(total);


        }
    }
}
