using System;

namespace T02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20Kg = double.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int bags = int.Parse(Console.ReadLine());

            double price = priceAbove20Kg;
            if (weight < 10)
            {
                price = priceAbove20Kg * 0.20;
            }
            else if (weight <= 20)
            {
                price = priceAbove20Kg * 0.50;
            }

            if (days < 7)
            {
                price *= 1.4;
            }
            else if (days <= 30)
            {
                price *= 1.15;
            }
            else
            {
                price *= 1.1;
            }

            price *= bags;
            Console.WriteLine($"The total price of bags is: {price:f2} lv.");
        }
    }
}
