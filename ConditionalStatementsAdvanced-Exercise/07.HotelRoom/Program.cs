using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceApartment = 0;
            double priceStudio = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 14)
                {
                    priceApartment = (nights * 65) - ((nights * 65) * 0.10);
                    priceStudio = (nights * 50) - ((nights * 50) * 0.3);
                }
                else if (nights > 7)
                {
                    priceStudio = (nights * 50) - ((nights * 50) * 0.05);
                    priceApartment = nights * 65;
                }
                else if (nights <= 7)
                {
                    priceStudio = nights * 50;
                    priceApartment = nights * 65;
                }
            }

            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceStudio = (nights * 75.20) - ((nights * 75.20) * 0.20);
                    priceApartment = (nights * 68.70) - ((nights * 68.70) * 0.10);
                }
                else
                {
                    priceStudio = nights * 75.20;
                    priceApartment = nights * 68.70;
                }
            }

            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceStudio = nights * 76;
                    priceApartment = (nights * 77) - ((nights * 77) * 0.10);
                }
                else
                {
                    priceStudio = nights * 76;
                    priceApartment = nights * 77;
                }

            }

                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            
        }
    }
}