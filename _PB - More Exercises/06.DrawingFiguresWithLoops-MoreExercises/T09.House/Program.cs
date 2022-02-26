using System;

namespace T09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.Write(new string('-', (n + 1) / 2 - row));
                Console.Write(new string('*', n % 2 == 0 ? row * 2 : row * 2 - 1));
                Console.WriteLine(new string('-', (n + 1) / 2 - row));
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
