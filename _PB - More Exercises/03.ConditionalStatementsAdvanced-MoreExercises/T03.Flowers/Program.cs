using System;

namespace T03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string dayType = Console.ReadLine();
            double price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price = chrysanthemums * 2 + roses * 4.10 + tulips * 2.50;
            }
            else
            {
                price = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
            }

            if (dayType == "Y")
            {
                price *= 1.15;
            }

            if (tulips > 7 && season == "Spring")
            {
                price *= 0.95;
            }

            if (roses >= 10 && season == "Winter")
            {
                price *= 0.90;
            }

            if (chrysanthemums + roses + tulips > 20)
            {
                price *= 0.80;
            }

            price += 2;

            Console.WriteLine($"{price:f2}");
        }
    }
}
