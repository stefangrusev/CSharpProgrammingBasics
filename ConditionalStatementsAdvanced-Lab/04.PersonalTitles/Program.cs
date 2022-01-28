using System;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double ages = double.Parse(Console.ReadLine());
            char gen = char.Parse(Console.ReadLine());

            switch (gen)
            {
                case 'm' when ages >= 16:
                    Console.WriteLine("Mr.");
                    break;
                case 'm' when ages < 16:
                    Console.WriteLine("Master");
                    break;
                case 'f' when ages >= 16:
                    Console.WriteLine("Ms.");
                    break;
                case 'f' when ages < 16:
                    Console.WriteLine("Miss");
                    break;
            }
        }
    }
}
