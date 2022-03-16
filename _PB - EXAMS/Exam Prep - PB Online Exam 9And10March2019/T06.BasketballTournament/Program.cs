using System;

namespace T06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();
            double wins = 0;
            int games = 0;

            while (tournament != "End of tournaments")
            {
                int matches = int.Parse(Console.ReadLine());
                for (int i = 1; i <= matches; i++)
                {
                    int desiTeamPoints = int.Parse(Console.ReadLine());
                    int otherTeamPoints = int.Parse(Console.ReadLine());
                    games++;

                    if (desiTeamPoints > otherTeamPoints)
                    {
                        wins++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {desiTeamPoints - otherTeamPoints} points.");
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {otherTeamPoints - desiTeamPoints} points.");
                    }
                }

                tournament = Console.ReadLine();
            }

            Console.WriteLine($"{wins / games * 100:f2}% matches win");
            Console.WriteLine($"{(games - wins) / games * 100:f2}% matches lost");
        }
    }
}
