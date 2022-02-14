using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = string.Empty;

            while (true)
            {
                Console.WriteLine(inputText);
                inputText = Console.ReadLine();

                if (inputText == "Stop")
                {
                    break;
                }
            }
        }
    }
}
