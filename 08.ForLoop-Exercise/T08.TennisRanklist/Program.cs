using System;

namespace T08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = 0;
            double wins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    points += 2000;
                    wins++;
                }
                else if (stage == "F")
                {
                    points += 1200;

                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }

            Console.WriteLine($"Final points: {startingPoints + points}");
            Console.WriteLine($"Average points: {points / tournaments}");
            Console.WriteLine($"{wins / tournaments * 100:f2}%");
        }
    }
}
