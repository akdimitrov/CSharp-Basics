using System;

namespace T06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int start4 = start % 10; start /= 10;
            int start3 = start % 10; start /= 10;
            int start2 = start % 10; start /= 10;
            int start1 = start % 10;

            int end4 = end % 10; end /= 10;
            int end3 = end % 10; end /= 10;
            int end2 = end % 10; end /= 10;
            int end1 = end % 10;


            for (int num1 = start1; num1 <= end1; num1++)
            {
                for (int num2 = start2; num2 <= end2; num2++)
                {
                    for (int num3 = start3; num3 <= end3; num3++)
                    {
                        for (int num4 = start4; num4 <= end4; num4++)
                        {
                            if (num1 % 2 != 0 && num2 % 2 != 0 &&
                                num3 % 2 != 0 && num4 % 2 != 0)
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
