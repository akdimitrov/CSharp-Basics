using System;

namespace T09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string feedback = Console.ReadLine();
            double price = 0;
            int nights = days - 1;

            if (type == "room for one person")
            {
                price = nights * 18.00;
            }
            else if (type == "apartment")
            {
                price = nights * 25.00;
                if (days < 10)
                {
                    price *= 0.70;
                }
                else if (days <= 15)
                {
                    price *= 0.65;
                }
                else
                {
                    price *= 0.50;
                }
            }
            else if (type == "president apartment")
            {
                price = nights * 35.00;
                if (days < 10)
                {
                    price *= 0.90;
                }
                else if (days <= 15)
                {
                    price *= 0.85;
                }
                else
                {
                    price *= 0.80;
                }
            }

            price = feedback == "positive" ? price * 1.25 : price * 0.90;
            Console.WriteLine($"{price:f2}");
        }
    }
}
