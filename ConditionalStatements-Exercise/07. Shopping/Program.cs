using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocard = int.Parse(Console.ReadLine());
            int cores = int.Parse(Console.ReadLine());
            int memory = int.Parse(Console.ReadLine());

            double priceVideocard = videocard * 250;
            double priceCores = cores * priceVideocard * 35 / 100.0;
            double priceMemory = memory * priceVideocard * 10 / 100.0;

            double necessaryMoney = priceVideocard + priceCores + priceMemory;
            double discount = videocard > cores ? necessaryMoney * 0.15 : 0;
            necessaryMoney -= discount;
            Console.WriteLine(budget>=necessaryMoney ? $"You have {budget-necessaryMoney:F2} leva left!" 
                                                     : $"Not enough money! You need {necessaryMoney-budget:F2} leva more!" );
        }
    }
}
