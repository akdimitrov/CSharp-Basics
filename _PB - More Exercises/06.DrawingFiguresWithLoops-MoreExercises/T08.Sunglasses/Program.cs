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
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.WriteLine(new string('*', n * 2));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                    if (row == (n + 1) / 2)
                        Console.Write(new string('|', n));
                    else
                        Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.WriteLine("*");
                }
            }
        }
    }
}
