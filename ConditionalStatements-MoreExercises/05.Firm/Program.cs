using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double hrsInWork = (days - (days * 0.10)) * 8;
            double overtime = 2 * days * employees;
            double totalTime = Math.Floor(overtime + hrsInWork);

            Console.WriteLine(totalTime < hours ? $"Not enough time!{Math.Abs(totalTime-hours)} hours needed." 
                                                : $"Yes!{Math.Abs(totalTime-hours)} hours left.");
        }
    }
}
