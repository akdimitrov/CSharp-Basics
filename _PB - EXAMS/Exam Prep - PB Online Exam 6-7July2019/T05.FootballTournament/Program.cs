using System;

namespace T05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            double wins = 0;
            int draws = 0;
            int losses = 0;
            int score = 0;

            for (int i = 0; i < games; i++)
            {
                char result = char.Parse(Console.ReadLine());
                switch (result)
                {
                    case 'W': score += 3; wins++; break;
                    case 'D': score += 1; draws++; break;
                    case 'L': losses++; break;
                }
            }

            if (games == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{team} has won {score} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wins}");
                Console.WriteLine($"## D: {draws}");
                Console.WriteLine($"## L: {losses}");
                Console.WriteLine($"Win rate: {wins / games * 100:f2}%");
            }
        }
    }
}
