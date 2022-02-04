using System;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int compareNumber = 0;
            int smallestNumber = 0;
            int biggestNumber = 0;
            for (int i = 0; i < num; i++)
            {
                compareNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    biggestNumber = compareNumber;
                    smallestNumber = compareNumber;
                }
                if (compareNumber > biggestNumber)
                {
                    biggestNumber = compareNumber;
                }
                else if (compareNumber < smallestNumber)
                {
                    smallestNumber = compareNumber;
                }
            }
            Console.WriteLine($"Max number: {biggestNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
        }
    }
}