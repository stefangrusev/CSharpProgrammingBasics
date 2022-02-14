using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int biggestNum = int.MinValue;

            while (n != "Stop")
            {
                int number = int.Parse(n);

                if (number > biggestNum)
                {
                    biggestNum = number;
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(biggestNum);
        }
    }
}
