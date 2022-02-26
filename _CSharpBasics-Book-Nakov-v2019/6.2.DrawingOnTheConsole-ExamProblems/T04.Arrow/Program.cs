using System;

namespace T04.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middle = n + 2 * (n / 2) - 4;

            Console.Write(new string('.', n / 2));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n / 2));

            for (int row = 1; row < n - 1; row++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("#");
                Console.Write(new string('.', n - 2));
                Console.Write("#");
                Console.WriteLine(new string('.', n / 2));
            }

            Console.Write(new string('#', n / 2 + 1));
            Console.Write(new string('.', n - 2));
            Console.WriteLine(new string('#', n / 2 + 1));

            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string('.', row));
                Console.Write("#");
                if (middle > 0)
                {
                    Console.Write(new string('.', middle));
                    Console.Write("#");
                }
                Console.WriteLine(new string('.', row));
                middle -= 2;
            }
        }
    }
}
