using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int stepsMore = 0;

            while (stepsMore < 10000)
            {

                string steps = Console.ReadLine();
                if (steps != "Going home")
                {
                    int stepsWalked = int.Parse(steps);
                    stepsMore += stepsWalked;
                }
                else if (steps == "Going home")
                {
                    stepsMore += int.Parse(Console.ReadLine());
                    Console.WriteLine(stepsMore >= 10000 ? $"Goal reached! Good job!{Environment.NewLine}{stepsMore - 10000} steps over the goal!" 
                                                         : $"{10000 - stepsMore} more steps to reach goal.");

                    return;
                }

            }

            Console.WriteLine($"Goal reached! Good job!{Environment.NewLine}{stepsMore-10000} steps over the goal!");

        }
    }
}
