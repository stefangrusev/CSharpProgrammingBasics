using System;

namespace _03Combinations
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;

                    if (i + j == number)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {number})");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {number}");

        }
    }
}
