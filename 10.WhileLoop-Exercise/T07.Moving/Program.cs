using System;

namespace T07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                volume -= int.Parse(input);
                if (volume < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
