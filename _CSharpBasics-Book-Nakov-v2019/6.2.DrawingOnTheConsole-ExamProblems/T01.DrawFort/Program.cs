using System;

namespace T01.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int col = n / 2;
            int middle = n * 2 - 2 * (n / 2) - 4;

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.Write("/");
                    Console.Write(new string('^', col));
                    Console.Write("\\");
                    if (n > n / 2 + 2)
                    {
                        Console.Write(new string('_', middle));
                    }
                    Console.Write("/");
                    Console.Write(new string('^', col));
                    Console.Write("\\");
                }
                else if (row > 1 && row < n)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', n / 2 + 1));
                    if (n > n / 2 + 2)
                    {
                        if (row == n - 1)
                        {
                            Console.Write(new string('_', middle));
                        }
                        else
                        {
                            Console.Write(new string(' ', middle));
                        }
                    }
                    Console.Write(new string(' ', n / 2 + 1));
                    Console.Write("|");
                }
                else
                {
                    Console.Write("\\");
                    Console.Write(new string('_', col));
                    Console.Write("/");
                    if (n > n / 2 + 2)
                    {
                        Console.Write(new string(' ', middle));
                    }
                    Console.Write("\\");
                    Console.Write(new string('_', col));
                    Console.Write("/");
                }
                Console.WriteLine();
            }
        }
    }
}
