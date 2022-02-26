using System;

namespace T06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a1 = k; a1 <= 8; a1++)
            {
                if (a1 % 2 != 0)
                    continue;
                for (int a2 = 9; a2 >= l; a2--)
                {
                    if (a2 % 2 == 0)
                        continue;
                    for (int b1 = m; b1 <= 8; b1++)
                    {
                        if (b1 % 2 != 0)
                            continue;
                        for (int b2 = 9; b2 >= n; b2--)
                        {
                            if (b2 % 2 == 0)
                                continue;
                            if (a1 == b1 && a2 == b2)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{a1}{a2} - {b1}{b2}");
                                counter++;
                            }

                            if (counter == 6)
                                return;
                        }
                    }
                }
            }
        }
    }
}
