using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double necessaryMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int daysPassedInSpend = 0;
            int daysPassed = 0;

            while (money < necessaryMoney)
            {
                string saveOrSpendText = Console.ReadLine();
                double saveOrSpendMoney = double.Parse(Console.ReadLine());

                if (saveOrSpendText == "spend")
                {
                    daysPassedInSpend++;
                    daysPassed++;
                    money -= saveOrSpendMoney;
                    if (money < 0)
                    {
                        money = 0;
                    }

                    if (daysPassedInSpend >= 5)
                    {
                        Console.WriteLine($"You can't save the money.{Environment.NewLine}{daysPassed}");
                        Environment.Exit(0);
                    }
                }
                else if (saveOrSpendText == "save")
                {
                    daysPassed++;
                    daysPassedInSpend = 0;
                    money += saveOrSpendMoney;
                }
            }

                    Console.WriteLine($"You saved the money for {daysPassed} days.");

        }
    }
}
