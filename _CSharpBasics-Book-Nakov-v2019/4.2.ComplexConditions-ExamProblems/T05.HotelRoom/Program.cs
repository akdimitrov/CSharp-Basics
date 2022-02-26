using System;

namespace T05.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studiotPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studiotPrice = nights * 50;
                apartmentPrice = nights * 65;
                if (nights > 14)
                {
                    studiotPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
                else if (nights > 7)
                {
                    studiotPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studiotPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if (nights > 14)
                {
                    studiotPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studiotPrice = nights * 76;
                apartmentPrice = nights * 77;
                if (nights > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studiotPrice:f2} lv.");
        }
    }
}
