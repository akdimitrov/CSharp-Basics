using System;

namespace T03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineries = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;

            if (joineries < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                if (size == "90X130")
                {
                    price = 110;
                    if (joineries > 60)
                    {
                        price *= 0.92;
                    }
                    else if (joineries > 30)
                    {
                        price *= 0.95;
                    }
                }
                else if (size == "100X150")
                {
                    price = 140;
                    if (joineries > 80)
                    {
                        price *= 0.90;
                    }
                    else if (joineries > 40)
                    {
                        price *= 0.94;
                    }
                }
                else if (size == "130X180")
                {
                    price = 190;
                    if (joineries > 50)
                    {
                        price *= 0.88;
                    }
                    else if (joineries > 20)
                    {
                        price *= 0.93;
                    }
                }
                else if (size == "200X300")
                {
                    price = 250;
                    if (joineries > 50)
                    {
                        price *= 0.86;
                    }
                    else if (joineries > 25)
                    {
                        price *= 0.91;
                    }
                }

                price *= joineries;
                if (delivery == "With delivery")
                {
                    price += 60;
                }

                if (joineries > 99)
                {
                    price *= 0.96;
                }

                Console.WriteLine($"{price:f2} BGN");
            }
        }
    }
}
