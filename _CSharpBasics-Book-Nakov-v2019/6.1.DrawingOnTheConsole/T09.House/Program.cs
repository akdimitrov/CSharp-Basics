using System;

namespace T09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (n % 2 == 0 && row <= n / 2)
                {
                    Console.Write(new string('-', n / 2 - row));
                    Console.Write(new string('*', 2 * row));
                    Console.Write(new string('-', n / 2 - row));
                }
                else if (n % 2 != 0 && row <= n / 2 + 1)
                {
                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.Write(new string('*', 2 * row - 1));
                    Console.Write(new string('-', (n + 1) / 2 - row));
                }
                else
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('*', n - 2));
                    Console.Write(new string('|', 1));
                }
                Console.WriteLine();
            }
        }
    }
}

