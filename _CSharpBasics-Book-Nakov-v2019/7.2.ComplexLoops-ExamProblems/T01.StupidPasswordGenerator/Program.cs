using System;

namespace T01.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 97; c < 97 + l; c++)
                    {
                        for (int d = 97; d < 97 + l; d++)
                        {
                            for (int e = 2; e <= n; e++)
                            {
                                if (e > a && e > b)
                                {
                                Console.Write($"{a}{b}{(char)c}{(char)d}{e} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
