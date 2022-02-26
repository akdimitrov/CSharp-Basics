using System;

namespace T05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int additionalPoints = 0;
            double wins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    wins++;
                    additionalPoints += 2000;
                }
                else if (stage == "F")
                {
                    additionalPoints += 1200;
                }
                else if (stage == "SF")
                {
                    additionalPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {initialPoints + additionalPoints}");
            Console.WriteLine($"Average points: {additionalPoints / tournaments}");
            Console.WriteLine($"{wins / tournaments * 100:f2}%");
        }
    }
}
