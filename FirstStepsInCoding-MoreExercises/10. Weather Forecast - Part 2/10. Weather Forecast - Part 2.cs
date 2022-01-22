using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weather = double.Parse(Console.ReadLine());
            if (26.00 <= weather && 35.00 >= weather)
            {
                Console.WriteLine("Hot");
            }
            else if (20.1 <= weather && 25.9 >= weather)
            {
                Console.WriteLine("Warm");
            }
            else if (15.00 <= weather && 20.00 >= weather)
            {
                Console.WriteLine("Mild");
            }
            else if (12.00 <= weather && 14.9 >= weather)
            {
                Console.WriteLine("Cool");
            }
            else if (5.00 <= weather && 11.9 >= weather)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
