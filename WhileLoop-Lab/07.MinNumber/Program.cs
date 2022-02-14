using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int smallestNumber = int.MaxValue;

            while (n != "Stop")
            {
                int number = int.Parse(n);

                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
