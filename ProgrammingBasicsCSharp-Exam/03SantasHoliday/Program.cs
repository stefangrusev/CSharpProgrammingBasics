using System;

namespace _03SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomForOnePersonPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;
            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                totalPrice = nights * roomForOnePersonPrice;
            }

            else if (roomType == "apartment")
            {
                if (nights < 10)
                {
                    apartmentPrice *= 0.70;
                }
                else if (nights <= 15)
                {
                    apartmentPrice *= 0.65;
                }
                else
                {
                    apartmentPrice *= 0.50;
                }

                totalPrice = nights * apartmentPrice;

            }

            else if (roomType == "president apartment")
            {
                if (nights < 10)
                {
                    presidentApartmentPrice *= 0.90;
                }
                else if (nights <= 15)
                {
                    presidentApartmentPrice *= 0.85;
                }
                else
                {
                    presidentApartmentPrice *= 0.80;
                }

                totalPrice = nights * presidentApartmentPrice;

            }

            if (rating == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
