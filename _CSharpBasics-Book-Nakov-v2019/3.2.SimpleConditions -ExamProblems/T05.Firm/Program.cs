using System;

namespace T05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            double days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double totalHours = Math.Floor(days * 0.9 * employees * 10);

            if (hoursNeeded <= totalHours)
            {
                Console.WriteLine($"Yes!{totalHours - hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - totalHours} hours needed.");
            }
        }
    }
}
