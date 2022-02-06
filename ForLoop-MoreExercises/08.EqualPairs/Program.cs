using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double difference = 0;
            double previousSum = 0;
            double lastSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double firstN = double.Parse(Console.ReadLine());
                double secondN = double.Parse(Console.ReadLine());

                double currentSum = firstN + secondN;

                if (n == 1)
                {
                    lastSum = currentSum;
                    previousSum = currentSum;
                    break;
                }

                if (Math.Abs(previousSum - currentSum) > difference  && i != 1)
                {
                    difference = Math.Abs(previousSum - currentSum);
                }
                
                if (i == n)
                {
                    lastSum = currentSum;
                    break;
                }

                previousSum = currentSum;

            }

            if (lastSum == previousSum)
            {
            Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
            Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}
