using System;

namespace T02.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int totalToys = 0;
            int moneyGift = 0;
            int evenCounter = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyGift += 10 * evenCounter - 1;
                    evenCounter++;
                }
                else
                {
                    totalToys++;
                }
            }

            moneyGift += totalToys * toyPrice;

            if (washingMachinePrice <= moneyGift)
            {
                Console.WriteLine($"Yes! {moneyGift - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - moneyGift:f2}");
            }
        }
    }
}
