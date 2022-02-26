using System;

namespace T04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeGoal = double.Parse(Console.ReadLine());
            double profit = 0;

            string drink = Console.ReadLine();
            while (drink != "Party!")
            {
                int count = int.Parse(Console.ReadLine());
                double drinkPrice = drink.Length * count;
                if (drinkPrice % 2 != 0)
                {
                    drinkPrice *= 0.75;
                }

                profit += drinkPrice;
                if (profit >= incomeGoal)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                drink = Console.ReadLine();
            }

            if (drink == "Party!")
            {
                Console.WriteLine($"We need {incomeGoal - profit:f2} leva more.");
            }

            Console.WriteLine($"Club income - {profit:f2} leva.");
        }
    }
}
