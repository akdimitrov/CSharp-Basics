using System;

namespace T08_1.Sunglasses
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
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write(new string('*', 1));

                    if (n % 2 == 0 && row == n / 2)
                    {
                        Console.Write(new string('|', n));
                    }
                    else if (n % 2 != 0 && row == n / 2 + 1)
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }

                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine();
                }
            }
        }
    }
}
