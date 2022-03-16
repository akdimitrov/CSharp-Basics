using System;

namespace T05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());

            for (int i = 0; i < series; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                switch (name)
                {
                    case "Thrones": price *= 0.50; break;
                    case "Lucifer": price *= 0.60; break;
                    case "Protector": price *= 0.70; break;
                    case "TotalDrama": price *= 0.80; break;
                    case "Area": price *= 0.90; break;
                }

                budget -= price;
            }

            if (budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
            }
        }
    }
}
