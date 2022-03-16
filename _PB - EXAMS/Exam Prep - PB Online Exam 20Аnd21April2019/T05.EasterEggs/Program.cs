using System;

namespace T05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int max = 0;
            int prevMax = 0;
            string colorMax = "";

            for (int i = 0; i < paintedEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red": red++; break;
                    case "orange": orange++; break;
                    case "blue": blue++; break;
                    case "green": green++; break;
                }

                max = Math.Max(Math.Max(red, orange), Math.Max(blue, green));
                if (max != prevMax)
                {
                    colorMax = color;
                }
                prevMax = max;
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {colorMax}");
        }
    }
}
