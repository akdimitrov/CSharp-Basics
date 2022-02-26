using System;

namespace T07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int amountGPU = int.Parse(Console.ReadLine());
            int amountCPU = int.Parse(Console.ReadLine());
            int amountRAM = int.Parse(Console.ReadLine());

            double priceGPU = amountGPU * 250;
            double priceCPU = priceGPU * 0.35 * amountCPU;
            double priceRAM = priceGPU * 0.10 * amountRAM;

            double totalPrice = priceCPU + priceGPU + priceRAM;

            if (amountGPU > amountCPU)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
