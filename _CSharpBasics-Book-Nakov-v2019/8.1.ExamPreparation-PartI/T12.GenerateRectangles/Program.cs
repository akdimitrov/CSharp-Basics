using System;

namespace T12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int rectangles = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int a = Math.Abs(right - left);
                            int b = Math.Abs(bottom - top);
                            int area = a * b;

                            if (area >= m)
                            {
                                rectangles++;
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                            }
                        }
                    }
                }
            }

            if (rectangles == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
