using System;

namespace T05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double points = 0;
            double low = 0;
            double mid = 0;
            double average = 0;
            double good = 0;
            double excellent = 0;
            double nevalid = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0 || num > 50)
                {
                    nevalid++;
                    points /= 2.0;
                }
                else if (num < 10)
                {
                    low++;
                    points += num * 0.20;
                }
                else if (num < 20)
                {
                    mid++;
                    points += num * 0.30;
                }
                else if (num < 30)
                {
                    average++;
                    points += num * 0.40;
                }
                else if (num < 40)
                {
                    good++;
                    points += 50;
                }
                else
                {
                    excellent++;
                    points += 100;
                }
            }

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {low / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {mid / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {average / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {good / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {excellent / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {nevalid / n * 100:f2}%");
        }
    }
}
