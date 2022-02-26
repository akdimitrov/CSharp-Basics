using System;

namespace T03.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes + 15;

            hours = timeInMinutes / 60;
            minutes = timeInMinutes % 60;

            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine("{0}:{1:d2}", hours, minutes);
        }
    }
}
