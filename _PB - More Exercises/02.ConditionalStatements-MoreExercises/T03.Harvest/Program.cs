using System;

namespace T03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSqrM = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wineYield = area * 0.4 * grapesPerSqrM / 2.5;
            if (wineYield < neededWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - wineYield)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineYield)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineYield - neededWine)} liters left -> {Math.Ceiling((wineYield - neededWine) / workers)} liters per person.");
            }
        }
    }
}
