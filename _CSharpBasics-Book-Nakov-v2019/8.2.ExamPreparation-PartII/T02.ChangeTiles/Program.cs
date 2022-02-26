using System;

namespace T02.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workerPrice = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLength;
            double tileArea = (tileSide * tileHeight) / 2;
            double totalTiles = Math.Ceiling(floorArea / tileArea) + 5;
            double totalTilesPrice = totalTiles * tilePrice;
            double totalSum = totalTilesPrice + workerPrice;
            savedMoney -= totalSum;

            if (savedMoney >= 0)
            {
                Console.WriteLine($"{savedMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {Math.Abs(savedMoney):f2} lv more.");
            }
        }
    }
}
