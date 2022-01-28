using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());
           
            double commision = 0;
            
            switch (city)
            {
                case "Sofia":
                    if (sellings > 0 && sellings <= 500)
                    {
                        commision = sellings * 0.05;
                    }
                    else if (sellings > 0 && sellings <= 1000)
                    {
                        commision = sellings * 0.07;
                    }
                    else if (sellings > 0 && sellings <= 10000)
                    {
                        commision = sellings * 0.08;
                    }
                    else if (sellings > 0 && sellings > 10000)
                    {
                        commision = sellings * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sellings > 0 && sellings <= 500)
                    {
                        commision = sellings * 0.045;
                    }
                    else if (sellings > 0 && sellings <= 1000)
                    {
                        commision = sellings * 0.075;
                    }
                    else if (sellings > 0 && sellings <= 10000)
                    {
                        commision = sellings * 0.10;
                    }
                    else if (sellings > 0 && sellings > 10000)
                    {
                        commision = sellings * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sellings > 0 && sellings <= 500)
                    {
                        commision = sellings * 0.055;
                    }
                    else if (sellings > 0 && sellings <= 1000)
                    {
                        commision = sellings * 0.08;
                    }
                    else if (sellings > 0 && sellings <= 10000)
                    {
                        commision = sellings * 0.12;
                    }
                    else if (sellings > 0 && sellings > 10000)
                    {
                        commision = sellings * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (commision != 0)
            {
                Console.WriteLine($"{commision:f2}");
            }
            else if (commision < 0)
            {
                Console.WriteLine("error");
            }


        }
    }
}