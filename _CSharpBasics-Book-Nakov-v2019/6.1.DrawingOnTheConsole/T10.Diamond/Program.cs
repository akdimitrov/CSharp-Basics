using System;

namespace T10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hyphens = 1;

            if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write(new string('-', n / 2 - row));
                    Console.Write('*');
                    Console.Write(new string('-', (row - 1) * 2));
                    Console.Write('*');
                    Console.Write(new string('-', n / 2 - row));
                    Console.WriteLine();
                }

                for (int row = n / 2 - 1; row >= 1; row--)
                {
                    Console.Write(new string('-', n / 2 - row));
                    Console.Write('*');
                    Console.Write(new string('-', (row - 1) * 2));
                    Console.Write('*');
                    Console.Write(new string('-', n / 2 - row));
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 1; row <= n / 2 + 1; row++)
                {

                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.Write('*');
                    if (row > 1)
                    {
                        Console.Write(new string('-', hyphens));
                        hyphens += 2;
                        Console.Write('*');
                    }
                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.WriteLine();
                }

                for (int row = n / 2; row >= 1; row--)
                {

                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.Write('*');
                    if (row > 1)
                    {
                        hyphens -= 2;
                        Console.Write(new string('-', hyphens - 2));
                        Console.Write('*');
                    }
                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.WriteLine();
                }
            }
        }
    }
}
