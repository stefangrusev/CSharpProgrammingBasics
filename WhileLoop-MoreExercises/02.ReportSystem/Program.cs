using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedMoney = int.Parse(Console.ReadLine());

            int counter = 0;
            int counterCash = 0;
            int counterCard = 0;
            double moneyInCash = 0;
            double moneyByCard = 0;
            double finalPrice = 0;

            string command = "";
            double price = 0;

            while (finalPrice < expectedMoney)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    Environment.Exit(0);
                }
                price = int.Parse(command);
                counter++;
                if (counter % 2 == 0)
                {

                    moneyInCash += price;
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        moneyInCash -= price;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterCash++;
                    }
                }
                else
                {

                    moneyByCard += price;
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        moneyByCard -= price;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        counterCard++;
                    }
                }

                finalPrice = moneyInCash + moneyByCard;
            }
            if (finalPrice >= expectedMoney)
            {
                Console.WriteLine($"Average CS: {moneyByCard / counterCard:F2}");
                Console.WriteLine($"Average CC: {moneyInCash / counterCash:F2}");
            }
        }
    }
}
