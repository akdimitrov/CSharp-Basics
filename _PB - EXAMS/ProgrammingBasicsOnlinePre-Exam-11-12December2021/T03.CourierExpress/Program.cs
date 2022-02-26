using System;

namespace T03.CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double price = 0;

            if (weight < 1)
            {
                price = 0.03;
            }
            else if (weight < 10)
            {
                price = 0.05;
            }
            else if (weight < 40)
            {
                price = 0.10;
            }
            else if (weight < 90)
            {
                price = 0.15;
            }
            else if (weight < 150)
            {
                price = 0.20;
            }

            if (type == "express")
            {
                if (weight < 1)
                {
                    price += (price * 0.80) * weight;
                }
                else if (weight < 10)
                {
                    price += (price * 0.40) * weight;
                }
                else if (weight < 40)
                {
                    price += (price * 0.05) * weight;
                }
                else if (weight < 90)
                {
                    price += (price * 0.02) * weight;
                }
                else if (weight < 150)
                {
                    price += (price * 0.01) * weight;
                }
            }

            price *= distance;

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");
        }
    }
}
