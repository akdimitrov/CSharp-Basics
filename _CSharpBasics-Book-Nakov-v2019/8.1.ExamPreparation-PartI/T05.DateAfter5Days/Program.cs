using System;

namespace T05.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            day += 5;

            switch (month)
            {
                case 2:
                    if (day > 28)
                    {
                        day -= 28;
                        month++;
                    }
                    break;

                case 4: case 6: case 9: case 11:
                    if (day > 30)
                    {
                        day -= 30;
                        month++;
                    }
                    break;

                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (day > 31)
                    {
                        day -= 31;
                        month++;
                    }
                    break;
            }

            if (month > 12)
            {
                month -= 12;
            }

            Console.WriteLine($"{day}.{month:d2}");
        }
    }
}
