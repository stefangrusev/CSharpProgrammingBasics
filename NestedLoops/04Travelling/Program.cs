using System;

namespace _04Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minimumBudget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < minimumBudget)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
