using System;

namespace T06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalMoney = 0;
            int dailyWins = 0;
            int dailyLosses = 0;

            for (int i = 0; i < days; i++)
            {
                int gameWins = 0;
                int gameLosses = 0;
                double dailyMoney = 0;
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        gameWins++;
                        dailyMoney += 20;
                    }
                    else
                    {
                        gameLosses++;
                    }

                    sport = Console.ReadLine();
                }

                if (gameWins > gameLosses)
                {
                    dailyWins++;
                    dailyMoney *= 1.1;
                }
                else
                {
                    dailyLosses++;
                }

                totalMoney += dailyMoney;
            }

            if (dailyWins > dailyLosses)
            {
                totalMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
