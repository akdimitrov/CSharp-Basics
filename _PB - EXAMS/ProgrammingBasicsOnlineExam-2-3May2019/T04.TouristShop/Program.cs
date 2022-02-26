using System;

namespace T04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            int counter = 0;
            int totalProducts = 0;
            double totalPrice = 0;

            while (product != "Stop")
            {
                counter++;
                double price = double.Parse(Console.ReadLine());
                if (counter == 3)
                {
                    price /= 2;
                    counter = 0;
                }

                totalProducts++;
                totalPrice += price;
                if (totalPrice > budget)
                {
                    break;
                }
                product = Console.ReadLine();
            }

            if (product == "Stop")
            {
                Console.WriteLine($"You bought {totalProducts} products for {totalPrice:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(totalPrice - budget):f2} leva!");
            }
        }
    }
}
