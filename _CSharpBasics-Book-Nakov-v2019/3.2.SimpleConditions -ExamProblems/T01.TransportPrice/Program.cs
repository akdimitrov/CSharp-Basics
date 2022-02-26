using System;

namespace T01.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string option = Console.ReadLine();
            double lowestPrice = int.MaxValue;

            if (distance >= 100)
            {
                lowestPrice = distance * 0.06;
            }
            else if (distance >= 20)
            {
                lowestPrice = distance * 0.09;
            }
            else
            {
                if (option == "day")
                {
                    lowestPrice = 0.79 * distance + 0.70;
                }
                else if (option == "night")
                {
                    lowestPrice = 0.90 * distance + 0.70;
                }
            }

            Console.WriteLine(Math.Round(lowestPrice, 2));

        }
    }
}
