using System;

namespace _04VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesPerBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysPerBook = int.Parse(Console.ReadLine());

            int sumHours = pagesPerBook / pagesPerHour;
            int dailyHours = sumHours / daysPerBook;

            Console.WriteLine(dailyHours);

        }
    }
}
