using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hrs = 0; hrs <= 23; hrs++)
            {
                for (int mins = 0; mins <= 59; mins++)
                {
                    Console.WriteLine($"{hrs}:{mins}");
                }
            }
        }
    }
}
