using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (100 >= num)
            {
                bonus = 5;
            }
            else if (1000 < num)
            {
                bonus = num * 0.1;
            }
            else
            {
                bonus = num * 0.2;
            }
            if (num % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num+bonus); 
        }
    }
}
