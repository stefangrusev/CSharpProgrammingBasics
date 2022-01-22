using System;

namespace _07AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfPiece = Console.ReadLine();

            if (typeOfPiece == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double areaSquare = sideOfSquare * sideOfSquare;
                Console.WriteLine($"{areaSquare:F3}");
            }
            else if (typeOfPiece == "rectangle")
            {
                double sideOneOfRectangle = double.Parse(Console.ReadLine());
                double sideTwoOfRectangle = double.Parse(Console.ReadLine());
                double areaRectangle = sideOneOfRectangle * sideTwoOfRectangle;
                Console.WriteLine($"{areaRectangle:F3}");
            }
            else if (typeOfPiece == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * (radius * radius);
                Console.WriteLine($"{areaCircle:F3}");
            }
            else if (typeOfPiece == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                double areaTriangle = (sideOfTriangle * heightOfTriangle) / 2;
                Console.WriteLine($"{areaTriangle:F3}");
            }
        }
    }
}
