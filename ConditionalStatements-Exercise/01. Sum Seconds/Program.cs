using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int total = firstTime + secondTime + thirdTime;
            int mins = total / 60;
            int sec = total % 60;
            if (sec < 10)
            {
                Console.WriteLine($"{mins}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{mins}:{sec}");
            }
        }
    }
}
