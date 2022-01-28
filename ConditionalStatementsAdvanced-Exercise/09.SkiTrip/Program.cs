using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;
            double nights = days - 1;
            double totalPrice = 0;
            
            if (days < 10)
            {
                if (typeRoom == "room for one person")
                {
                    price = nights * 18;
                }
                else if (typeRoom == "apartment")
                {
                    price = (nights * 25) - ((nights * 25) * 0.30);
                }
                else if (typeRoom == "president apartment")
                {
                    price = (nights * 35) - ((nights * 35) * 0.10);
                }
            }

            else if (days >= 10 && days < 15)
            {
                if (typeRoom == "room for one person")
                {
                    price = nights * 18;
                }
                else if (typeRoom == "apartment")
                {
                    price = (nights * 25) - ((nights * 25) * 0.35);
                }
                else if (typeRoom == "president apartment")
                {
                    price = (nights * 35) - ((nights * 35) * 0.15);
                }
            }

            else if (days >= 15)
            {
                if (typeRoom == "room for one person")
                {
                    price = nights * 18;
                }
                else if (typeRoom == "apartment")
                {
                    price = (nights * 25) - ((nights * 25) * 0.50);
                }
                else if (typeRoom == "president apartment")
                {
                    price = (nights * 35) - ((nights * 35) * 0.20);
                }
            }

            switch (rating)
            {
                case "positive":
                    totalPrice = price + (price * 0.25);
                    break;
                case "negative":
                    totalPrice = price - (price * 0.10);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");





        }

    }
}
