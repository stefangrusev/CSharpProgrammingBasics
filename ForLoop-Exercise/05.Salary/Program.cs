using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int charge = 0;


            for (int i = 1; i <= openTabs; i++)
            {

                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    charge += 150;
                }
                else if (site == "Instagram")
                {
                    charge += 100;
                }
                else if (site == "Reddit")
                {
                    charge += 50;
                }

                if (charge >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (charge < salary)
            {
                Console.WriteLine(salary-charge);
            }
        }
    }
}
