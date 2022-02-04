using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            for (int i = 1; i <= jury; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                points += ((juryName.Length * juryPoints) / 2);

                if (points >= 1250.5)
                {
                    break;
                }
            }

            Console.WriteLine( points >= 1250.5 ? $"Congratulations, {nameActor} got a nominee for leading role with {points:f1}!"
                                                : $"Sorry, {nameActor} you need {1250.5 - points:f1} more!");
        }
    }
}
