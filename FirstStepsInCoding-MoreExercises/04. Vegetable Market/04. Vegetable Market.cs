using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVeggies = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            int totalKgVeggies = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());

            double priceForVeggies = pricePerKgVeggies * totalKgVeggies;
            double priceForFruits = pricePerKgFruits * totalKgFruits;
            double totalinLeva = priceForVeggies + priceForFruits;
            double totalInEuro = totalinLeva / 1.94;

            Console.WriteLine($"{totalInEuro:f2}");
        }
    }
}
