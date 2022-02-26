using System;

namespace T01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double unbrellaPrice = double.Parse(Console.ReadLine());

            double finalPrice = entranceFee * people + Math.Ceiling(people / 2) * unbrellaPrice + Math.Ceiling(people * 0.75) * sunbedPrice;

            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
