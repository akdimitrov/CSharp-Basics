using System;

namespace T09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double priceForGreening = area * 7.61;
            double discount = priceForGreening * 0.18;
            double finalPrice = priceForGreening - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
