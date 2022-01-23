using System;

namespace FuelTank
{
    class FuelTank
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double filledFuel = double.Parse(Console.ReadLine());

            string fuelDiesel = "diesel";
            string fuelGasoline = "gasoline";
            string fuelGas = "gas";
            string print = string.Empty;
            
            if (typeOfFuel != "Diesel" && typeOfFuel != "Gasoline" && typeOfFuel != "Gas")
            {
                print = "Invalid fuel!";
            }
            
            else if (typeOfFuel == "Diesel")
            {
                if (filledFuel >= 25)
                {
                    print = $"You have enough {fuelDiesel}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelDiesel}!";
                }
            }
            
            else if (typeOfFuel == "Gasoline")
            {
                if (filledFuel >= 25)
                {
                    print = $"You have enough {fuelGasoline}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelGasoline}!";
                }
            }
            
            else if (typeOfFuel == "Gas")
            {
                if (filledFuel >= 25)
                {
                    print = $"You have enough {fuelGas}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelGas}!";
                }
            }

            Console.WriteLine(print);
        }
    }
}