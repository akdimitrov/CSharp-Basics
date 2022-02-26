using System;

namespace T04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int steps = 0;

            while (steps < 10000)
            {
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    steps += int.Parse(input);
                    break;
                }
                steps += int.Parse(input);
                input = Console.ReadLine();
            }

            if (steps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }
    }
}
