using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                int numFor = int.Parse(Console.ReadLine());
                sumNumbers += numFor;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
