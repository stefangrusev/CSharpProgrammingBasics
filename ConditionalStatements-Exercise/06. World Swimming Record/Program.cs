using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double timePerSecond = distance * time;
            double delay = Math.Floor(distance / 15) * 12.5;
            double wholeTime = timePerSecond + delay;

            Console.WriteLine(wholeTime < record ? $"Yes, he succeeded! The new world record is {wholeTime:F2} seconds." : $"No, he failed! He was {Math.Abs(record-wholeTime):F2} seconds slower." );
            
        }
    }
}
