using System;

namespace _05BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {            
            string bestPlayer = "";
            int bestPlayerGoals = 0;
            string name = "";
            int goals = 0;

            while (true)
            {
                name = Console.ReadLine();
               
                if (name == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());

                if (goals > bestPlayerGoals)
                {
                    bestPlayerGoals = goals;
                    bestPlayer = name;

                    if (goals >= 10)
                    {
                        break;
                    }
                }
                             

            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            Console.WriteLine(bestPlayerGoals >= 3 ? $"He has scored {bestPlayerGoals} goals and made a hat-trick !!!" 
                                                   : $"He has scored {bestPlayerGoals} goals.");

        }
    }
}
