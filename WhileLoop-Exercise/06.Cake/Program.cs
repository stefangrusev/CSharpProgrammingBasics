using System;

namespace _06.Cake
    {
        class Program
        {
            static void Main(string[] args)
            {
                int lenght = int.Parse(Console.ReadLine());
                int width = int.Parse(Console.ReadLine());
                int cakePieces = lenght * width;
                string comands = Console.ReadLine();
                while (cakePieces >= 0)
                {
                    if (comands == "STOP")
                    {
                        break;
                    }
                    int cake = int.Parse(comands);
                    cakePieces -= cake;
                    comands = Console.ReadLine();
                }
                if (cakePieces >= 0)
                {
                    Console.WriteLine($"{cakePieces} pieces are left.");
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
                }
            }
        }
    }