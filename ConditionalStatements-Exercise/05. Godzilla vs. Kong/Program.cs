using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());
            double moneyOutfit = employees*outfit;
            double decor = budget / 10.0;
            if (employees > 150)
            {
                moneyOutfit = moneyOutfit - moneyOutfit /10.0;
            }
            double moneyEmplOutfit = employees * moneyOutfit;
            double decorPlusOutfit = moneyOutfit + decor;
            if (decorPlusOutfit > budget)
            {
                Console.WriteLine("Not enough money!");
                double lessMoney =  decorPlusOutfit - budget;
                Console.WriteLine($"Wingard needs {lessMoney:F2} leva more.");
            }
            else if (decorPlusOutfit<=budget)
            {
                Console.WriteLine("Action!");
                double moreMoney = budget - decorPlusOutfit;
                Console.WriteLine($"Wingard starts filming with {moreMoney:F2} leva left.");
            }
        }
    }
}
