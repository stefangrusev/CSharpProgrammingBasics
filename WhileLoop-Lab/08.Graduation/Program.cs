using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int repeatedGrade = 0;
            int year = 1;
            double average = 0;

            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;

                if (grade < 4)
                {
                    repeatedGrade++;
                    if (repeatedGrade > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {year} grade");
                        return;
                    }

                    year--;

                }

                year++;

            }

            double averageGrade = average / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");

        }
    }
}
