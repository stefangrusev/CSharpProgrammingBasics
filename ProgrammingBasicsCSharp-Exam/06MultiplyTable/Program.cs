using System;

namespace _06MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int firstNumber = int.Parse(n[2].ToString());
            int secondNumber = int.Parse(n[1].ToString());
            int thirdNumber = int.Parse(n[0].ToString());

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int k = 1; k <= thirdNumber; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k};");
                    }
                }
            }

        }
    }
}
