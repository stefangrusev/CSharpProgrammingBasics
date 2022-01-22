using System;

namespace _07FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityChickenMenus = int.Parse(Console.ReadLine());
            int quantityFishMenus = int.Parse(Console.ReadLine());
            int quantityVeggyMenus = int.Parse(Console.ReadLine());

            double totalChicken = quantityChickenMenus * 10.35;
            double totalFish = quantityFishMenus * 12.40;
            double totalVeggy = quantityVeggyMenus * 8.15;
            double totalDessert = (totalChicken + totalFish + totalVeggy) * 20 / 100.0;
            double delivery = 2.50; //fixed 
            double priceForTheDelivery = delivery + totalDessert + totalVeggy + totalFish + totalChicken;

            Console.WriteLine(priceForTheDelivery);
        }
    }
}
