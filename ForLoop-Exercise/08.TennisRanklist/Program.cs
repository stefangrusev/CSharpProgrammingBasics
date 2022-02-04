using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int averagePoints = 0;
            int wins = 0;
            string ranking = "";

            for (int i = 1; i <= tournaments; i++)
            {
                ranking = Console.ReadLine();
                if (ranking == "W")
                {
                    points += 2000;
                    averagePoints += 2000;
                    wins++;
                }
                else if (ranking == "F")
                {
                    points += 1200;
                    averagePoints += 1200;
                }
                else if (ranking == "SF")
                {
                    points += 720;
                    averagePoints += 720;
                }
            }

            int sumPoints = points;
            double sumAveragePoints = averagePoints/tournaments;
            double percent = (wins * 1.00 / tournaments) * 100;

            Console.WriteLine($"Final points: {sumPoints}");
            Console.WriteLine($"Average points: {Math.Round(sumAveragePoints)}");
            Console.WriteLine($"{percent:f2}%");

        }
    }
}
