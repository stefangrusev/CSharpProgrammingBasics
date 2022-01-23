using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double priceMagnolias = magnolias * 3.25;
            double priceHyacinths = hyacinths * 4;
            double priceRoses = roses * 3.50;
            double priceCactus = cactus * 8;
            double order = priceMagnolias + priceHyacinths + priceRoses + priceCactus;

            double orderAfterTaxes = order - (order * 5/100.0);
            Console.WriteLine(orderAfterTaxes>=gift ? $"She is left with {Math.Floor(orderAfterTaxes-gift)} leva."  
                                                    : $"She will have to borrow {Math.Ceiling(gift-orderAfterTaxes)} leva."); 
        }
    }
}
