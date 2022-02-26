using System;

namespace T04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double price = 0;

            if (distance >= 100)
            {
                price = distance * 0.06;
            }
            else if (distance >= 20)
            {
                price = distance * 0.09;
            }
            else
            {
                price = dayNight == "day" ? distance * 0.79 + 0.7 : distance * 0.90 + 0.7;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
