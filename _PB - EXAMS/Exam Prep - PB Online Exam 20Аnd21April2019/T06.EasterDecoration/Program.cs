using System;

namespace T06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double profit = 0;

            for (int i = 0; i < clients; i++)
            {
                int items = 0;
                double spentMoney = 0;
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    items++;
                    switch (input)
                    {
                        case "basket": spentMoney += 1.50; break;
                        case "wreath": spentMoney += 3.80; break;
                        case "chocolate bunny": spentMoney += 7.00; break;
                    }

                    input = Console.ReadLine();
                }

                if (items % 2 == 0)
                {
                    spentMoney *= 0.80;
                }

                profit += spentMoney;
                Console.WriteLine($"You purchased {items} items for {spentMoney:f2} leva.");
            }

            Console.WriteLine($"Average bill per client is: {profit / clients:f2} leva.");
        }
    }
}
