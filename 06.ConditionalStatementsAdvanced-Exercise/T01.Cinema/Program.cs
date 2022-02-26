using System;

namespace T01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seats = rows * cols;
            double profit = seats;

            if (projectionType == "Premiere")
            {
                profit *= 12.00;
            }
            else if (projectionType == "Normal")
            {
                profit *= 7.50;
            }
            else if (projectionType == "Discount")
            {
                profit *= 5.00;
            }

            Console.WriteLine("{0:f2} leva", profit);
        }
    }
}
