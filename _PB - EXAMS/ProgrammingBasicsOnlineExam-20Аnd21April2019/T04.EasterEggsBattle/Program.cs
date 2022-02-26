using System;

namespace T04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                if (input == "one")
                {
                    secondPlayerEggs--;
                }
                else if (input == "two")
                {
                    firstPlayerEggs--;
                }

                if (firstPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    break;
                }
                else if (secondPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
