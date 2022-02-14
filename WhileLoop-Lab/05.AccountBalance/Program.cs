using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string income = Console.ReadLine();
            double total = 0;

            while (income != "NoMoreMoney")
            {
                double incomeValue = double.Parse(income);

                if (incomeValue <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += incomeValue;

                Console.WriteLine($"Increase: {incomeValue:f2}");

                income = Console.ReadLine();

            }

                Console.WriteLine($"Total: {total:f2}");
                        
        }
    }
}
