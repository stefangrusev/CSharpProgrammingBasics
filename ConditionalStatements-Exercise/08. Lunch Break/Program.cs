using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int timeOfSerial = int.Parse(Console.ReadLine());
            int @break = int.Parse(Console.ReadLine());

            double lunch = @break*1.00 / 8;
            double rest = @break*1.00 / 4;
            double freetime = @break - rest - lunch;
            Console.WriteLine(timeOfSerial <= freetime ? $"You have enough time to watch {serial} and left with {Math.Ceiling(freetime - timeOfSerial)} minutes free time."
                                                       : $"You don't have enough time to watch {serial}, you need {Math.Ceiling(timeOfSerial - freetime)} more minutes.");


        }
    }
}
