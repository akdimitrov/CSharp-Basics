using System;

namespace T01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourAmount = double.Parse(Console.ReadLine());
            double sugarAmount = double.Parse(Console.ReadLine());
            int eggBoxes = int.Parse(Console.ReadLine());
            int yeastPacks = int.Parse(Console.ReadLine());

            double sugarPrice = flourPrice * 0.75;
            double eggBoxPrice = flourPrice * 1.10;
            double yeastPrice = sugarPrice * 0.20;
            double totalPrice = flourPrice * flourAmount + sugarPrice * sugarAmount + eggBoxPrice * eggBoxes + yeastPrice * yeastPacks;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
