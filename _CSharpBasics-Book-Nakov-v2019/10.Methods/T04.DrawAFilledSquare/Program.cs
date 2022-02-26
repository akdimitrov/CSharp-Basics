using System;

namespace T04.DrawAFilledSquare
{
    class Program
    {
        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBody(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void PrintFilledSquare(int n)
        {
            PrintHeaderFooter(n);
            PrintBody(n);
            PrintHeaderFooter(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }
    }
}
