using System;

namespace T03.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int inside = n * 2 - 1;

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', n * 2 + 1));
            Console.WriteLine(new string('.', n + 1));

            for (int row = 1; row <= n + 1; row++)
            {
                Console.Write(new string('.', n - row + 1));
                Console.Write("//");
                if (row == n + 1)
                {
                    Console.Write(new string('_', (inside - 5) / 2));
                    Console.Write("STOP!");
                    Console.Write(new string('_', (inside - 5) / 2));
                }
                else
                {
                    Console.Write(new string('_', inside));
                }
                Console.Write("\\\\");
                Console.Write(new string('.', n - row + 1));

                Console.WriteLine();
                inside += 2;
            }

            inside -= 2;

            for (int row = n + 1; row > 1; row--)
            {
                Console.Write(new string('.', n - row + 1));
                Console.Write("\\\\");
                Console.Write(new string('_', inside));
                Console.Write("//");
                Console.Write(new string('.', n - row + 1));

                Console.WriteLine();
                inside -= 2;
            }
        }
    }
}
