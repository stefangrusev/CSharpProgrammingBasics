using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightHouse = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double heightTriangularRoofWall = double.Parse(Console.ReadLine());

            double sideWallArea = heightHouse * sideWallLength;
            double windowsArea = 1.5 * 1.5;
            double bothSides = 2 * sideWallArea - 2 * windowsArea;
            double backWall = heightHouse * heightHouse;
            double doorArea = 1.2 * 2;
            double backFrontWallsArea = backWall * 2 - doorArea;
            double sumArea = bothSides + backFrontWallsArea;
            double greenPaint = sumArea / 3.4;
            Console.WriteLine($"{greenPaint:F2}");

            double sidesRoof = 2 * (heightHouse * sideWallLength);
            double backFrontWallsRoof = 2 * (heightHouse * heightTriangularRoofWall / 2);
            double sumAreaRoof = sidesRoof + backFrontWallsRoof;
            double redPaint = sumAreaRoof / 4.3;
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
