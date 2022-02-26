using System;

namespace T06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cake = a * b;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int peaces = int.Parse(input);
                cake -= peaces;
                if (cake <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
