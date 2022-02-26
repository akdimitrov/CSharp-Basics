using System;

namespace T05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("***");
            Console.WriteLine(new string('.', 2 * n - 1));

            for (int row = 2; row <= 2 * n; row++)
            {
                Console.Write(new string('.', 2 * n - row));
                Console.Write("*");
                Console.Write(new string('-', row - 1));
                Console.Write("*");
                Console.Write(new string('-', row - 1));
                Console.Write("*");
                Console.WriteLine(new string('.', 2 * n - row));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write("*");
            for (int i = 0; i < 2 * n; i++)
                Console.Write(".*");
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
