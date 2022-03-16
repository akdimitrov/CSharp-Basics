using System;

namespace T06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxPoints = int.MinValue;
            string winner = "";

            while (name != "Stop")
            {
                int points = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (points >= maxPoints)
                {
                    maxPoints = points;
                    winner = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
