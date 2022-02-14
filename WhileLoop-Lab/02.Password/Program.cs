using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            string truePass = string.Empty;

            while (pass != truePass)
            {
                truePass = Console.ReadLine();

                if (pass == truePass)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}
