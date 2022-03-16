using System;

namespace T04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string field = Console.ReadLine();
            int points = 301;
            int falseShots = 0;
            int successfulShots = 0;

            while (field != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());
                switch (field)
                {
                    case "Double": currentPoints *= 2; break;
                    case "Triple": currentPoints *= 3; break;
                }

                if (currentPoints <= points)
                {
                    points -= currentPoints;
                }
                else
                {
                    falseShots++;
                    field = Console.ReadLine();
                    continue;
                }

                successfulShots++;
                if (points == 0)
                {
                    break;
                }

                field = Console.ReadLine();
            }

            if (field == "Retire")
            {
                Console.WriteLine($"{name} retired after {falseShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
        }
    }
}
