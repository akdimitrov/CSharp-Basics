using System;

namespace T04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double actorFee = 0;
            while (name != "ACTION")
            {
                if (name.Length > 15)
                {
                    actorFee = budget * 0.2;
                }
                else
                {
                    actorFee = double.Parse(Console.ReadLine());

                }

                budget -= actorFee;
                if (budget < 0)
                {
                    break;
                }

                name = Console.ReadLine();
            }

            if (name == "ACTION")
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
        }
    }
}
