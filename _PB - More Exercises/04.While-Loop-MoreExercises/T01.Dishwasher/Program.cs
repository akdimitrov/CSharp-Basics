using System;

namespace T01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int detergent = bottles * 750;
            int load = 0;
            int plates = 0;
            int pots = 0;

            while (command != "End")
            {
                load++;
                int dishes = int.Parse(command);

                if (load == 3)
                {
                    pots += dishes;
                    detergent -= dishes * 15;
                    load = 0;
                }
                else
                {
                    plates += dishes;
                    detergent -= dishes * 5;
                }

                if (detergent < 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
