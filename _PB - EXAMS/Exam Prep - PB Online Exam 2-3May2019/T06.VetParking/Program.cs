using System;

namespace T06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int day = 1; day <= days; day++)
            {
                double dailyPrice = 0;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        dailyPrice += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        dailyPrice += 1.25;
                    }
                    else
                    {
                        dailyPrice++;
                    }
                }
                totalPrice += dailyPrice;
                Console.WriteLine($"Day: {day} - {dailyPrice:f2} leva");
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
