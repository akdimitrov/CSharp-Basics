using System;

namespace T05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDashes = (n - 1) * 2;
            int firstDashes = 5 * n - lastDashes - 2;
            int innerDasehs = 0;

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                Console.Write(new string('-', innerDasehs));
                Console.Write("*");
                Console.WriteLine(new string('-', lastDashes));
                lastDashes--;
                innerDasehs++;
            }

            lastDashes++;
            innerDasehs--;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', firstDashes));
                Console.Write("*");
                Console.Write(new string('-', innerDasehs));
                Console.Write("*");
                Console.WriteLine(new string('-', lastDashes));
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                if (i == n / 2)
                {
                    Console.Write(new string('*', innerDasehs));
                }
                else
                {
                    Console.Write(new string('-', innerDasehs));
                }
                Console.Write("*");
                Console.WriteLine(new string('-', lastDashes));
                firstDashes--;
                lastDashes--;
                innerDasehs += 2;
            }
        }
    }
}
