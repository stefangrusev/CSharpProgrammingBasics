using System;

namespace FuelTankpt2
{
    class FuelTankpt2
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type != "Gas" && type != "Diesel" && type != "Gasoline")
            {
                return;
            }
            
            double amount = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            
            if (clubCard != "Yes" && clubCard != "No")
            {
                return;
            }


            if (clubCard == "Yes")
            {
               
                if (type == "Gas")
                {
                    double price = amount * 0.93;
                    double discount = price - (amount * 0.08);

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = discount * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                   
                    else if (amount > 25)
                    {
                        double totalPrice = discount * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    
                    else
                    {
                        Console.WriteLine($"{discount:F2} lv.");
                    }
                }

                if (type == "Gasoline")
                {
                    double price = amount * 2.22;
                    double discount = price - (amount * 0.18);

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = discount * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                 
                    else if (amount > 25)
                    {
                        double totalPrice = discount * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                
                    else
                    {
                        Console.WriteLine($"{discount:F2} lv.");
                    }
                }
                
                if (type == "Diesel")
                {
                    double price = amount * 2.33;
                    double discount = price - (amount * 0.12);

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = discount * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    
                    else if (amount > 25)
                    {
                        double totalPrice = discount * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    
                    else
                    {
                        Console.WriteLine($"{discount:F2} lv.");
                    }
                }
            }
            else
            {
                if (type == "Gas")
                {
                    double price = amount * 0.93;

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = price * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else if (amount > 25)
                    {
                        double totalPrice = price * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:F2} lv.");
                    }
                }
                if (type == "Gasoline")
                {
                    double price = amount * 2.22;

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = price * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else if (amount > 25)
                    {
                        double totalPrice = price * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:F2} lv.");
                    }
                }
                if (type == "Diesel")
                {
                    double price = amount * 2.33;

                    if (amount >= 20 && amount <= 25)
                    {
                        double totalPrice = price * 0.92;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else if (amount > 25)
                    {
                        double totalPrice = price * 0.9;
                        Console.WriteLine($"{totalPrice:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:F2} lv.");
                    }
                }

            }
        }
    }
}