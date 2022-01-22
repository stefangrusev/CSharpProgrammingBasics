using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzles = puzzles * 2.60;
            double priceDolls = dolls * 3;
            double priceBears = bears * 4.10;
            double priceMinions = minions * 8.20;
            double priceTrucks = trucks * 2;

            double priceToys = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;
            double numberOfToys = puzzles + dolls + bears + minions + trucks;

            if (numberOfToys >= 50)
            {
                priceToys = priceToys - (priceToys * 0.25);
            }
            double totalPrice = priceToys - (priceToys * 0.1);
            double profit = totalPrice - trip;
            if (profit >= 0)
            {
                Console.WriteLine($"Yes! {profit:F2} lv left.");
            }
            else
            {
                profit = profit * -1;
                Console.WriteLine($"Not enough money! {profit:F2} lv needed.");
            }
        }
    }
}
