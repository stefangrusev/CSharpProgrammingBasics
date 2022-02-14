using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumNumbers = 0;

            while (number > sumNumbers)
            {
                sumNumbers += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sumNumbers);

        }
    }
}
