using System;

namespace T11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int day = 1; day <= days; day++)
            {
                double dailySum = 0;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        dailySum += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        dailySum += 1.25;
                    }
                    else
                    {
                        dailySum++;
                    }
                }

                Console.WriteLine($"Day: {day} - {dailySum:f2} leva");
                totalSum += dailySum;
            }

            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
