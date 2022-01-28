using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();

            double moneySpent = 0;
            string destination = "";
            string where = "";

            if (budget <= 100)
            {
                if (seasson == "summer")
                {
                    moneySpent = budget * 0.30;
                    destination = "Bulgaria";
                    where = "Camp";
                }
                else if (seasson == "winter")
                {
                    moneySpent = budget * 0.70;
                    destination = "Bulgaria";
                    where = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (seasson == "summer")
                {
                    moneySpent = budget * 0.40;
                    destination = "Balkans";
                    where = "Camp";
                }
                else if (seasson == "winter")
                {
                    moneySpent = budget * 0.80;
                    destination = "Balkans";
                    where = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                moneySpent = budget * 0.90;
                destination = "Europe";
                where = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{where} - {moneySpent:f2}");

        }
    }
}
