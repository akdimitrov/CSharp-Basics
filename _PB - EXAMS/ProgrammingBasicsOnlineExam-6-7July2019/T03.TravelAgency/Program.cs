using System;

namespace T03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string option = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            bool isValid = true;

            if (city == "Bansko" || city == "Borovets")
            {
                if (option == "withEquipment")
                {
                    price = 100;
                    if (vip == "yes")
                    {
                        price *= 0.90;
                    }
                }
                else if (option == "noEquipment")
                {
                    price = 80;
                    if (vip == "yes")
                    {
                        price *= 0.95;
                    }
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (option == "withBreakfast")
                {
                    price = 130;
                    if (vip == "yes")
                    {
                        price *= 0.88;
                    }
                }
                else if (option == "noBreakfast")
                {
                    price = 100;
                    if (vip == "yes")
                    {
                        price *= 0.93;
                    }
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }

            if (days > 7)
            {
                days--;
            }

            price *= days;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (isValid)
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
