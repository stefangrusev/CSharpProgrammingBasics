using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double moreThanFive = 0;
            double fourAndFive = 0;
            double threeAndFour = 0;
            double lessThanThree = 0;
            double average = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    moreThanFive++;
                }

                else if (grade >= 4 && grade <= 4.99)
                {
                    fourAndFive++;
                }

                else if (grade >= 3 && grade <= 3.99)
                {
                    threeAndFour++;
                }

                else if (grade < 3)
                {
                    lessThanThree++;
                }

                average += grade;
                
            }

            Console.WriteLine("Top students: {0:f2}%", (moreThanFive / students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (fourAndFive / students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (threeAndFour / students) * 100);
            Console.WriteLine("Fail: {0:f2}%", (lessThanThree / students) * 100);
            Console.WriteLine("Average: {0:f2}", average / students);

        }
    }
}
