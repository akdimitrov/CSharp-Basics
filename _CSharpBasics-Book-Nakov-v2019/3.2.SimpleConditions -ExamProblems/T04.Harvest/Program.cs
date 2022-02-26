using System;

namespace T04.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSquareM = double.Parse(Console.ReadLine());
            int wineLitersNeeded = int.Parse(Console.ReadLine());
            int labours = int.Parse(Console.ReadLine());

            double grapesForWine = area * grapesPerSquareM * 0.4;
            double wine = grapesForWine / 2.5;

            if (wine < wineLitersNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLitersNeeded - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - wineLitersNeeded)} liters left -> {Math.Ceiling((wine - wineLitersNeeded) / labours)} liters per person.");
            }


        }
    }
}
