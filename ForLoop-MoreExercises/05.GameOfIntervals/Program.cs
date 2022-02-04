using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double turns = double.Parse(Console.ReadLine());

            double interval = 0;

            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;

            double invalidn = 0;

            for (int i = 0; i < turns; i++)
            {
                double result = double.Parse(Console.ReadLine());

                if (result >= 0 && result <= 9)
                {
                    from0to9++;
                    interval += result * 0.20;
                }

                else if (result >= 10 && result <= 19)
                {
                    from10to19++;
                    interval += result * 0.30;
                }

                else if (result >= 20 && result <= 29)
                {
                    from20to29++;
                    interval += result * 0.40;
                }

                else if (result >= 30 && result <= 39)
                {
                    from30to39++;
                    interval += 50;
                }

                else if (result >= 40 && result <= 50)
                {
                    from40to50++;
                    interval += 100;
                }

                else
                {
                    invalidn++;
                    interval = interval / 2;
                }
            }

            Console.WriteLine($"{interval:f2}");
            Console.WriteLine($"From 0 to 9: {((from0to9 / turns) * 100):f2}%");
            Console.WriteLine($"From 10 to 19: {((from10to19 / turns) * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {((from20to29 / turns) * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {((from30to39 / turns) * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {((from40to50 / turns) * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {((invalidn / turns) * 100):f2}%");

        }
    }
}
