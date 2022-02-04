using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityCargo = int.Parse(Console.ReadLine());

            double priceBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;

            double cargoSum = 0;

            double cargoBus = 0;
            double cargoTruck = 0;
            double cargoTrain = 0;

            for (int i = 1; i <= quantityCargo; i++)
            {
                int cargoTonnage = int.Parse(Console.ReadLine());

                cargoSum += cargoTonnage;

                if (cargoTonnage <= 3)
                {
                    cargoBus += cargoTonnage;
                    priceBus += cargoTonnage * 200;
                }

                if (cargoTonnage >= 4 && cargoTonnage <= 11)
                {
                    cargoTruck += cargoTonnage;
                    priceTruck += cargoTonnage * 175;
                }

                if (cargoTonnage >= 12)
                {
                    cargoTrain += cargoTonnage;
                    priceTrain += cargoTonnage * 120;
                }

            }

         double averagePrice = (priceBus + priceTruck + priceTrain) / cargoSum;
         Console.WriteLine($"{averagePrice:f2}");

         double percentTonsBus = cargoBus / cargoSum * 100;
         Console.WriteLine($"{percentTonsBus:f2}%");

         double percentTonsTruck = cargoTruck / cargoSum * 100;
         Console.WriteLine($"{percentTonsTruck:f2}%");

         double percentTonsTrain = cargoTrain / cargoSum * 100;
         Console.WriteLine($"{percentTonsTrain:f2}%");

        }
    }
}
