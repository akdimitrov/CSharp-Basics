using System;

namespace T10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.Write(new string('-', (n + 1) / 2 - row));
                Console.Write("*");
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', (row - 1) * 2));
                    Console.Write("*");
                }
                else
                {
                    if (row > 1)
                    {
                        Console.Write(new string('-', (row - 1) * 2 - 1));
                        Console.Write("*");
                    }
                }
                Console.WriteLine(new string('-', (n + 1) / 2 - row));
            }

            for (int row = (n + 1) / 2 - 1; row >= 1; row--)
            {
                Console.Write(new string('-', (n + 1) / 2 - row));
                Console.Write("*");
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', (row - 1) * 2));
                    Console.Write("*");
                }
                else
                {
                    if (row > 1)
                    {
                        Console.Write(new string('-', (row - 1) * 2 - 1));
                        Console.Write("*");
                    }
                }
                Console.WriteLine(new string('-', (n + 1) / 2 - row));
            }
        }
    }
}
