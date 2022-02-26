using System;

namespace T01.CrossingSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int spiral = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            bool isFound = false;

            while (true)
            {
                int count = 0;
                int turn = 0;
                int breakPoint = 2;

                for (int i = spiral; i <= num1; i += step)
                {
                    count++;
                    if (spiral == num1)
                    {
                        isFound = true;
                        break;
                    }

                    if (count == breakPoint)
                    {
                        count = 1;
                        turn++;
                        if (turn == 2)
                        {
                            breakPoint++;
                            turn = 0;
                        }
                        if (i == num1)
                        {
                            isFound = true;
                            break;
                        }
                    }
                }

                if (isFound)
                {
                    break;
                }

                int tribonacciNum = num1 + num2 + num3;
                num1 = num2;
                num2 = num3;
                num3 = tribonacciNum;

                if (num1 > 1000000)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
