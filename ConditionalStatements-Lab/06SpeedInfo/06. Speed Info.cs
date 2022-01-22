using System;

namespace _06SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            if (10 >= speed)
            {
                Console.WriteLine("slow");
            }
            else if (10 <= speed && 50 >= speed)
            {
                Console.WriteLine("average");
            }
            else if (50 < speed && 150 >= speed)
            {
                Console.WriteLine("fast");
            }
            else if (150 < speed && 1000 >= speed)
            {
                Console.WriteLine("ultra fast");
            }
            else if (1000 < speed)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
