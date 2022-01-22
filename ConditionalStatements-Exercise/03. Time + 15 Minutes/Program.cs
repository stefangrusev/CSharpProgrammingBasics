using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrs = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int hrsToMins = hrs * 60;
            int timeInMins = (hrsToMins + mins) +15;
            hrs = timeInMins / 60;
            mins = timeInMins % 60;
            if (hrs >= 24)
            {
                hrs = hrs - 24;
            }
            if (mins < 10)
            {
                Console.WriteLine($"{hrs}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hrs}:{mins}");
            }
        }
    }
}
