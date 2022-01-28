using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char operatorType = char.Parse(Console.ReadLine());

            double result = 0;

            if (operatorType == '+' || operatorType == '-' || operatorType == '*')
            {
                if (operatorType == '+')
                {
                    result = numberOne + numberTwo;
                }
                else if (operatorType == '-')
                {
                    result = numberOne - numberTwo;
                }
                else if (operatorType == '*')
                {
                    result = numberOne * numberTwo;
                }
                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{numberOne} {operatorType} {numberTwo} = {result} - {evenOrOdd}");
            }
            else
            {
               if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
               else
                {
                    if (operatorType == '/')
                    {
                        result = 1.0 * numberOne / numberTwo;
                        Console.WriteLine($"{numberOne} {operatorType} {numberTwo} = {result:f2}");
                    }
                    else
                    {
                        result = numberOne % numberTwo;
                        Console.WriteLine($"{numberOne} {operatorType} {numberTwo} = {result}");
                    }
                }

            }



                      
        }
    }
}
