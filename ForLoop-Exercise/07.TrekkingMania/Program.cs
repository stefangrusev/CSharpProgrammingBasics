using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            
            int groupMusala = 0;
            int groupMonblan = 0;
            int groupK = 0;
            int groupK2 = 0;
            int groupEverest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    groupMusala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    groupMonblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    groupK += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    groupK2 += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    groupEverest += peopleInGroup;
                }
            }

            double allPeople = groupMusala + groupMonblan + groupK + groupK2 + groupEverest;

            Console.WriteLine($"{groupMusala/allPeople*100:f2}%");
            Console.WriteLine($"{groupMonblan/allPeople*100:f2}%");
            Console.WriteLine($"{groupK/allPeople*100:f2}%");
            Console.WriteLine($"{groupK2/allPeople*100:f2}%");
            Console.WriteLine($"{groupEverest/allPeople*100:f2}%");

        }

    }
}
