using System;

namespace ProgrammingBasicsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatPercent = int.Parse(Console.ReadLine());
            double proteinPercent = int.Parse(Console.ReadLine());
            double carbohydratesPercent = int.Parse(Console.ReadLine());
            double totalCalories = int.Parse(Console.ReadLine());
            double h2oPercent = int.Parse(Console.ReadLine());

            double gramsFat = (fatPercent / 100 * totalCalories) / 9;
            double gramsProteins = (proteinPercent / 100 * totalCalories) / 4;
            double gramsCarbohydrates = (carbohydratesPercent / 100 * totalCalories) / 4;

            double foodWeight = gramsFat + gramsProteins + gramsCarbohydrates;
            double caloriesPerGramFood = totalCalories / foodWeight;

            double totalh2o = (h2oPercent / 100) * caloriesPerGramFood;
            double calories = caloriesPerGramFood - totalh2o;

            Console.WriteLine($"{calories:f4}");
        }
    }
}
