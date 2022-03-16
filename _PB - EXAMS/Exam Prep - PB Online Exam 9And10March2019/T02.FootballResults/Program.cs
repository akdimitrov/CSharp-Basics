using System;

namespace T02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = Console.ReadLine();
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();
            int wins = 0;
            int losses = 0;
            int draws = 0;

            if (result1[0] < result1[2])
            {
                losses++;
            }
            else if (result1[0] > result1[2])
            {
                wins++;
            }
            else
            {
                draws++;
            }

            if (result2[0] < result2[2])
            {
                losses++;
            }
            else if (result2[0] > result2[2])
            {
                wins++;
            }
            else
            {
                draws++;
            }

            if (result3[0] < result3[2])
            {
                losses++;
            }
            else if (result3[0] > result3[2])
            {
                wins++;
            }
            else
            {
                draws++;
            }

            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losses} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
