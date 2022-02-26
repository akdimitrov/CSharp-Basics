using System;

namespace T08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine().ToLower();
            double price = 0;

            if (clubCard == "no")
            {
                switch (fuel)
                {
                    case "Gasoline": price = litres * 2.22; break;
                    case "Diesel": price = litres * 2.33; break;
                    case "Gas": price = litres * 0.93; break;
                }
            }
            else
            {
                switch (fuel)
                {
                    case "Gasoline": price = litres * 2.04; break;
                    case "Diesel": price = litres * 2.21; break;
                    case "Gas": price = litres * 0.85; break;
                }
            }

            if (litres > 25)
            {
                price *= 0.9;
            }
            else if (litres >= 20)
            {
                price *= 0.92;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
