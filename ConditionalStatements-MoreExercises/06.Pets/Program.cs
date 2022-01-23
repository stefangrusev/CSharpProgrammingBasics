using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodDogDaily = double.Parse(Console.ReadLine());
            double foodCatDaily = double.Parse(Console.ReadLine());
            double foodTurtleDailyGrams = double.Parse(Console.ReadLine());

            double foodTurtleDaily = foodTurtleDailyGrams / 1000;

            double sumDog = days * foodDogDaily;
            double sumCat = days * foodCatDaily;
            double sumTur = days * foodTurtleDaily;
            double sumFood = Math.Abs(sumDog + sumCat + sumTur);

            Console.WriteLine(sumFood<=food ? $"{Math.Floor(food-sumFood)} kilos of food left." 
                                            : $"{Math.Ceiling(sumFood-food)} more kilos of food are needed.");


        }
    }
}
