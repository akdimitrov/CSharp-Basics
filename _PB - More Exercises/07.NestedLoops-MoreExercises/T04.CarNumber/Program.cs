using System;

namespace T04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int num1 = start + 1; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    for (int num3 = start; num3 <= end; num3++)
                    {
                        if ((num2 + num3) % 2 != 0)
                        {
                            continue;
                        }

                        for (int num4 = start; num4 < end; num4++)
                        {
                            if (num1 > num4)
                            {
                                if (num1 % 2 == 0 && num4 % 2 != 0)
                                {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                                else if (num1 % 2 != 0 && num4 % 2 == 0)
                                {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
