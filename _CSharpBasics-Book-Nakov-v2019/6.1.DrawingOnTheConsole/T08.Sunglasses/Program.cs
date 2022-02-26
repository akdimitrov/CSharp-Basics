using System;

namespace T08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    for (int col = 1; col <= n * 2; col++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 1; col <= n * 2; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    continue;
                }

                Console.Write("*");
                for (int i = 1; i <= n * 2 - 2; i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                for (int i = 0; i < n; i++)
                {
                    if (n % 2 == 0 && row == n /2)
                    {
                        Console.Write("|");
                    }
                    else if (n % 2 != 0 && row == n / 2 + 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("*");
                for (int i = 1; i <= n * 2 - 2; i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
