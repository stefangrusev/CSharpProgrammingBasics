using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsolvedTask = int.Parse(Console.ReadLine());

            int failedTasks = 0;
            int resolvedTasks = 0;
            double sumGrades = 0;
            string lastTask = "";
            bool isFailed = true; //flag

            while (unsolvedTask > failedTasks)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTasks++;
                }

                sumGrades += grade;
                resolvedTasks++;
                lastTask = taskName;

            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {unsolvedTask} poor grades.");
            }
            else
            {
                double averageGrade = sumGrades / resolvedTasks;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {resolvedTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
