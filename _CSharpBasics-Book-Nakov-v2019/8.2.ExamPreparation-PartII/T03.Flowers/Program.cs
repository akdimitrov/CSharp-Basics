using System;

namespace T03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemums = int.Parse(Console.ReadLine());
            double roses = int.Parse(Console.ReadLine());
            double tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string dayType = Console.ReadLine().ToLower();

            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            if (season == "spring" || season == "summer")
            {
                chrysanthemumPrice = 2;
                rosePrice = 4.1;
                tulipPrice = 2.5;

                if (dayType == "y")
                {
                    chrysanthemumPrice = 2 * 1.15;
                    rosePrice = 4.1 * 1.15;
                    tulipPrice = 2.5 * 1.15;
                }
            }
            else if (season == "autumn" || season == "winter")
            {
                chrysanthemumPrice = 3.75;
                rosePrice = 4.5;
                tulipPrice = 4.15;

                if (dayType == "y")
                {
                    chrysanthemumPrice = 3.75 * 1.15;
                    rosePrice = 4.5 * 1.15;
                    tulipPrice = 4.15 * 1.15;
                }
            }

            double totalPrice = chrysanthemums * chrysanthemumPrice + roses * rosePrice + tulips * tulipPrice;
            double totalFlowers = chrysanthemums + roses + tulips;

            if (tulips > 7 && season == "spring")
            {
                totalPrice *= 0.95;
            }
            if (roses >= 10 && season == "winter")
            {
                totalPrice *= 0.90;
            }
            if (totalFlowers > 20)
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"{totalPrice + 2:f2}");
        }
    }
}
