using System;

namespace T05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string bestPlayer = "";
            int bestPlayerGoals = 0;

            while (name != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestPlayerGoals)
                {
                    bestPlayerGoals = goals;
                    bestPlayer = name;
                }

                if (goals >= 10)
                {
                    break;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}
