using System;

namespace T03.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int groundSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            double areaForTiles = groundSide * groundSide - (benchLength * benchWidth);
            double totalTiles = areaForTiles / (tileWidth * tileLength);
            double timeNeeded = totalTiles * 0.2;

            Console.WriteLine(totalTiles);
            Console.WriteLine(timeNeeded);
        }
    }
}
