using System;

namespace T05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0;

            for (int i = 0; i < soldGames; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone": hearthstone++; break;
                    case "Fornite": fornite++; break;
                    case "Overwatch": overwatch++; break;
                    default: others++; break;
                }
            }

            Console.WriteLine($"Hearthstone - {hearthstone / soldGames * 100:f2}%");
            Console.WriteLine($"Fornite - {fornite / soldGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {overwatch / soldGames * 100:f2}%");
            Console.WriteLine($"Others - {others / soldGames * 100:f2}%");
        }
    }
}
