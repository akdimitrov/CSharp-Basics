using System;

namespace T07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallsArea = 2 * (x * x) - (1.2 * 2) + 2 * ((x * y) - (1.5 * 1.5));
            double roofArea = x * y * 2 + 2 * ((x * h) / 2);
            double greePaintLitres = wallsArea / 3.4;
            double redPaintLitres = roofArea / 4.3;

            Console.WriteLine($"{greePaintLitres:f2}");
            Console.WriteLine($"{redPaintLitres:f2}");
        }
    }
}
