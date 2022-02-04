using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
                  
            for (int i = 0; i <= year - 1800; i++)
            {
                money -= i % 2 == 0 ? 12000 : 12000 + 50 * (18 + i);
            }

            Console.WriteLine(money >= 0 ? $"Yes! He will live a carefree life and will have {money:f2} dollars left." 
                                         : $"He will need {Math.Abs(money):f2} dollars to survive.");

        }
    }
}
