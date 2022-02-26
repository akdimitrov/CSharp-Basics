using System;

namespace T05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine()) * 1000;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                boughtFood -= eatenFood;
                input = Console.ReadLine();
            }

            if (boughtFood >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(boughtFood)} grams more.");
            }
        }
    }
}
