using System;

namespace T06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string winner = "";

            for (int i = 0; i < easterBreads; i++)
            {
                int totalPoints = 0;
                string name = Console.ReadLine();
                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    totalPoints += int.Parse(input);
                    input = Console.ReadLine();
                }

                Console.WriteLine($"{name} has {totalPoints} points.");
                if (totalPoints > maxPoints)
                {
                    winner = name;
                    maxPoints = totalPoints;
                    Console.WriteLine($"{name} is the new number 1!");
                }
            }

            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }
    }
}
