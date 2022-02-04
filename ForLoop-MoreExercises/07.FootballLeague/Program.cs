using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityStadium = double.Parse(Console.ReadLine());
            int allFans = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            double percentA = 0;
            double percentB = 0;
            double percentV = 0;
            double percentG = 0;
            double percentAll = 0;

            for (int i = 0; i < capacityStadium; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }

            percentA = (sectorA / allFans) * 100;
            percentB = (sectorB / allFans) * 100;
            percentV = (sectorV / allFans) * 100;
            percentG = (sectorG / allFans) * 100;

            percentAll = (allFans / capacityStadium) * 100;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percentAll:f2}%");

        }
    }
}