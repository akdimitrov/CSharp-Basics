using System;

namespace T01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            for (int num1 = 2; num1 <= n1; num1 += 2)
            {
                for (int num2 = 2; num2 <= n2; num2++)
                {
                    if (num2 > 7 || num2 == 4 || num2 == 6)
                        continue;
                    for (int num3 = 2; num3 <= n3; num3 += 2)
                    {
                        Console.WriteLine($"{num1} {num2} {num3}");
                    }
                }
            }
        }
    }
}
