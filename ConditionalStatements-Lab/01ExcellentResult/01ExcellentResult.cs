using System;

namespace _01ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double theNumber = double.Parse(Console.ReadLine());
            if (theNumber >= 5.50)
            if (theNumber <= 6.00)              
                {
                        Console.WriteLine("Excellent!");
                }
                else
                {
                    Console.WriteLine("Wrong answer! Try again!");
                }
        }
    }
}
