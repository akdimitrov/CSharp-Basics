using System;

namespace T05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = 5364;
            int days = 1;
            bool goalIsReached = false;
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "Yes")
                {
                    days++;
                }

                if (days > 5)
                {
                    break;
                }

                meters += int.Parse(Console.ReadLine());
                if (meters >= 8848)
                {
                    goalIsReached = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (goalIsReached)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{meters}");
            }
        }
    }
}
