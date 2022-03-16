using System;

namespace T04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            string input1 = Console.ReadLine();
            int player1Points = 0;
            int player2Points = 0;

            while (input1 != "End of game")
            {
                int card1 = int.Parse(input1);
                int card2 = int.Parse(Console.ReadLine());

                if (card1 > card2)
                {
                    player1Points += card1 - card2;
                }
                else if (card2 > card1)
                {
                    player2Points += card2 - card1;
                }
                else
                {
                    Console.WriteLine("Number wars!");
                    card1 = int.Parse(Console.ReadLine());
                    card2 = int.Parse(Console.ReadLine());

                    if (card1 > card2)
                    {
                        Console.WriteLine($"{player1} is winner with {player1Points} points");
                    }
                    else
                    {
                        Console.WriteLine($"{player2} is winner with {player2Points} points");
                    }

                    break;
                }

                input1 = Console.ReadLine();
            }

            if (input1 == "End of game")
            {
                Console.WriteLine($"{player1} has {player1Points} points");
                Console.WriteLine($"{player2} has {player2Points} points");
            }
        }
    }
}
