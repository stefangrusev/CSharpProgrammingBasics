using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackarel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgAji = double.Parse(Console.ReadLine());
            int kgMussels = int.Parse(Console.ReadLine());

            double Bonito = priceMackarel + priceMackarel * 0.60;
            double priceBonito = kgBonito * Bonito;
            double Aji = priceSprat + priceSprat * 0.80;
            double priceAji = kgAji * Aji;
            double priceMussels = kgMussels * 7.50;

            double sumPrice = priceBonito + priceAji + priceMussels;
            
            Console.WriteLine($"{sumPrice:F2}");
        }
    }
}
