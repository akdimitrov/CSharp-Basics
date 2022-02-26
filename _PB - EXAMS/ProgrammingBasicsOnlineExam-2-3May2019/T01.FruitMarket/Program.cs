using System;

namespace T01.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasWeight = double.Parse(Console.ReadLine());
            double orangesWeight = double.Parse(Console.ReadLine());
            double raspberriesWeight = double.Parse(Console.ReadLine());
            double strawberriesWeight = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice * 0.60;
            double bananasPrice = raspberriesPrice * 0.20;
            double totalPrice = strawberriesPrice * strawberriesWeight + bananasPrice * bananasWeight + orangesPrice * orangesWeight + raspberriesPrice * raspberriesWeight;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
