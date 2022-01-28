using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transport = 0;
            double ticketPrice = 0;

            if (category == "VIP")
            {
                if (people >= 1 && people <= 4)
                {
                    transport = budget - (budget - (budget * 0.75));
                }
                else if (people >= 5 && people <= 9)
                {
                    transport = budget - (budget - (budget * 0.60));
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = budget - (budget - (budget * 0.50));
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = budget - (budget - (budget * 0.40));
                }
                else
                {
                    transport = budget - (budget - (budget * 0.25));
                }
            }

            else if (category == "Normal")
            {
                if (people >= 1 && people <= 4)
                {
                    transport = budget - (budget - (budget * 0.75));
                }
                else if (people >= 5 && people <= 9)
                {
                    transport = budget - (budget - (budget * 0.60));
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = budget - (budget - (budget * 0.50));
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = budget - (budget - (budget * 0.40));
                }
                else
                {
                    transport = budget - (budget - (budget * 0.25));
                }
            }

            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }

            double moneyForTickets = budget - transport;
            double ticketsCosts = ticketPrice * people;

            Console.WriteLine(moneyForTickets > ticketsCosts ? $"Yes! You have {moneyForTickets - ticketsCosts:f2} leva left."
                                                              : $"Not enough money! You need {ticketsCosts - moneyForTickets:f2} leva.");

        }
    }
}
