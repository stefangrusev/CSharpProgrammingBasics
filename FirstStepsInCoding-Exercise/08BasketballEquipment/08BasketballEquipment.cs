using System;

namespace _08BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());

            double priceShoes = yearlyTax - (yearlyTax * 40 / 100.0);
            double priceOutfit = priceShoes - (priceShoes * 20 / 100.0);
            double priceBall = priceOutfit / 4;
            double priceAcc = priceBall / 5;

            double totalExpences = yearlyTax + priceShoes + priceOutfit + priceBall + priceAcc;

            Console.WriteLine(totalExpences);
        }
    }
}
