using System;

namespace T04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int soldEggs = 0;

            while (command != "Close")
            {
                int eggsNumber = int.Parse(Console.ReadLine());
                if (command == "Buy")
                {
                    if (eggs < eggsNumber)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggs}.");
                        break;
                    }
                    eggs -= eggsNumber;
                    soldEggs += eggsNumber;
                }
                else if (command == "Fill")
                {
                    eggs += eggsNumber;
                }
                command = Console.ReadLine();
            }

            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
