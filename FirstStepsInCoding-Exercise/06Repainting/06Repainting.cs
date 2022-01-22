using System;

namespace _06Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int necessaryProtectiveNylon = int.Parse(Console.ReadLine());
            int necessaryQuantityPaint = int.Parse(Console.ReadLine());
            int necessaryQuantitySeparator = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double MoneyProtectiveNylon = (necessaryProtectiveNylon + 2) * 1.50;
            double MoneyPaint = (necessaryQuantityPaint + necessaryQuantityPaint * 0.1) * 14.50;
            double MoneySeparator = necessaryQuantitySeparator * 5.00;
            double totalMoneyMaterials = MoneyProtectiveNylon + MoneyPaint + MoneySeparator + 0.40;
            double totalMoneyWorkers = (totalMoneyMaterials * 0.3) * hours;

            Console.WriteLine(totalMoneyMaterials + totalMoneyWorkers);
        }
    }
}
