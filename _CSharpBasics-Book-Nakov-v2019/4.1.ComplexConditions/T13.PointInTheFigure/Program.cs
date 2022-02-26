using System;

namespace T13.PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string output = "";

            if (x >= 0 && x <= h * 3 && y >= 0 && y <= h)
            {
                output = "inside";
                if (((x == 0 || x == h * 3) && y >= 0 && y <= h) ||
                    (x >= 0 && x <= h * 3 && y == 0) ||
                    (x >= 0 && x <= h && y == h) ||
                    (x >= h * 2 && x <= h * 3 && y == h))
                {
                    output = "border";
                }
            }
            else if (x >= h && x <= h * 2 && y >= h && y <= h * 4)
            {
                output = "inside";
                if (((x == h || x == h * 2) && y >= h && y <= h * 4) ||
                    (x >= h && x <= h * 2 && y == h * 4))
                {
                    output = "border";
                }
            }
            else
            {
                output = "outside";
            }

            Console.WriteLine(output);
        }
    }
}
