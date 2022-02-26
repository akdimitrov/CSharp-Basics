using System;

namespace T08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for (int num1 = 2; num1 <= hundreds; num1 += 2)
            {
                for (int num2 = 2; num2 <= tens; num2++)
                {
                    if (num2 == 4 || num2 == 6 || num2 > 7)
                        continue;
                    for (int num3 = 2; num3 <= units; num3 += 2)
                    {
                        Console.WriteLine($"{num1} {num2} {num3}");
                    }
                }
            }
        }
    }
}
