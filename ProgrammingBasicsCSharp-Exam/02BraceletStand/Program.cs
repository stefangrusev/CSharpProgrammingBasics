using System;

namespace _02BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double totalSpendings = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double savedMoney = 5 * moneyPerDay;
            double earnedMoney = 5 * dailyProfit;
            double totalMoney = (savedMoney + earnedMoney) - totalSpendings;

            Console.WriteLine(totalMoney >= giftPrice ? $"Profit: {totalMoney:f2} BGN, the gift has been purchased." 
                                                      : $"Insufficient money: {giftPrice-totalMoney:f2} BGN.");

        }
    }
}
