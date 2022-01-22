using System;

namespace _05Number100._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (100 > num)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= num && 200 >= num)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (200 < num)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
