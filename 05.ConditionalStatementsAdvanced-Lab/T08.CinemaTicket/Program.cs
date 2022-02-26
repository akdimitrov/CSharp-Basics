using System;

namespace T08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int price = 12;

            if (day == "Wednesday" || day == "Thursday")
            {
                price = 14;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                price = 16;
            }

            Console.WriteLine(price);
        }
    }
}
