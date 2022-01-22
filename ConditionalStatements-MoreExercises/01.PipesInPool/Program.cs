using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int debitFirstPipe = int.Parse(Console.ReadLine());
            int debitSecondPipe = int.Parse(Console.ReadLine());
            double hoursAbsence = double.Parse(Console.ReadLine());

            double firstHalfPool = debitFirstPipe * hoursAbsence;
            double secondHalfPool = debitSecondPipe * hoursAbsence;
            double wholePool = firstHalfPool + secondHalfPool;
            if (wholePool <= volume)
            {
                Console.WriteLine($"The pool is {(wholePool / volume) * 100:F2}% full. Pipe 1: {(firstHalfPool / wholePool) * 100:F2}%. Pipe 2: {(secondHalfPool / wholePool) * 100:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursAbsence:F2} hours the pool overflows with {wholePool-volume:F2} liters.");
            }
        }

    }
}
