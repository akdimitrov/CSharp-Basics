using System;

namespace T08.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int counterMaxValue = 0;
            int lastNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > lastNum)
                {
                    counter++;
                    if (counter > counterMaxValue)
                    {
                        counterMaxValue++;
                    }
                }
                else
                {
                    counter = 1;
                }

                lastNum = currentNum;
            }

            Console.WriteLine(counterMaxValue);
        }
    }
}
