using System;

namespace T04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalPrice = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
            int totalToys = puzzles + dolls + bears + minions + trucks;

            if (totalToys >= 50)
            {
                totalPrice *= 0.75;
            }

            totalPrice *= 0.90;

            if (holidayPrice <= totalPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - holidayPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - totalPrice:f2} lv needed.");
            }
        }
    }
}
