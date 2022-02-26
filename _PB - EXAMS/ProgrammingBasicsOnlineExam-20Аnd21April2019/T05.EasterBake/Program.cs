using System;

namespace T05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int sugarMax = int.MinValue;
            int flourMax = int.MinValue;
            int sugarTotal = 0;
            int flourTotal = 0;

            for (int i = 0; i < easterBreads; i++)
            {
                int sugarGrams = int.Parse(Console.ReadLine());
                int flourGrams = int.Parse(Console.ReadLine());
                if (sugarGrams > sugarMax)
                {
                    sugarMax = sugarGrams;
                }
                if (flourGrams > flourMax)
                {
                    flourMax = flourGrams;
                }

                sugarTotal += sugarGrams;
                flourTotal += flourGrams;
            }

            double sugarPacks = Math.Ceiling(sugarTotal / 950.0);
            double flourPacks = Math.Ceiling(flourTotal / 750.0);

            Console.WriteLine($"Sugar: {sugarPacks}");
            Console.WriteLine($"Flour: {flourPacks}");
            Console.WriteLine($"Max used flour is {flourMax} grams, max used sugar is {sugarMax} grams.");
        }
    }
}
