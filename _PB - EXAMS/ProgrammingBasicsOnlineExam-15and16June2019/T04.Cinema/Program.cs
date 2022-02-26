using System;

namespace T04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double profit = 0;
            while (input != "Movie time!")
            {
                int people = int.Parse(input);
                double price = people * 5;
                if (people % 3 == 0)
                {
                    price -= 5;
                }

                if (people > seats)
                {
                    break;
                }

                seats -= people;
                profit += price;
                input = Console.ReadLine();
            }

            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {seats} seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }

            Console.WriteLine($"Cinema income - {profit} lv.");
        }
    }
}
