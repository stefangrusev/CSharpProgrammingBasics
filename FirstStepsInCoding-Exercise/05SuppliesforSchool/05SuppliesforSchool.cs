using System;

namespace _05SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packOfPens = int.Parse(Console.ReadLine());
            int packOfMarkers = int.Parse(Console.ReadLine());
            int bottleOfDetegrent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double moneyForPens = packOfPens * 5.80;
            double moneyForMarkers = packOfMarkers * 7.20;
            double moneyForDetegrent = bottleOfDetegrent * 1.20;
            double moneyDiscount = discount / 100.0;

            double totalMoney = moneyForPens + moneyForMarkers + moneyForDetegrent;

            Console.WriteLine(totalMoney - (totalMoney * moneyDiscount));

        }
    }
}
