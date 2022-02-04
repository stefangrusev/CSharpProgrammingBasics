using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * 5 - 1;
                }
                else if (i % 2 != 0)
                {
                    sum += toy;
                }
            }

            Console.WriteLine(sum>=price?$"Yes! {sum-price:f2}"
                                        :$"No! {price-sum:f2}");

        }
    }
}
