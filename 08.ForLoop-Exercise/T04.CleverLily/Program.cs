using System;

namespace T04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double toysPrice = 0;
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 * i / 2 - 1;
                }
                else
                {
                    toysPrice += toyPrice;
                }
            }

            money += toysPrice;

            if (money >= price)
            {
                Console.WriteLine($"Yes! {money - price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {price - money:f2}");
            }
        }
    }
}
