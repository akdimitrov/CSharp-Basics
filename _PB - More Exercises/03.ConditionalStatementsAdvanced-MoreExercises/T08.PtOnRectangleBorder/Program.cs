using System;

namespace T08.PtOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool onLowerUpperBorder = x >= x1 && x <= x2 && (y == y2 || y == y1);
            bool onleftRightBorder = y >= y1 && y <= y2 && (x == x2 || x == x1);

            if (onleftRightBorder || onLowerUpperBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
