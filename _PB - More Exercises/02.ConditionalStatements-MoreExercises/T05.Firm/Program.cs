using System;

namespace T05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            double projectdays = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double hoursTotal = Math.Floor(projectdays * 0.9 * 8 + projectdays * employees * 2);

            if (projectHours <= hoursTotal)
            {
                Console.WriteLine($"Yes!{hoursTotal - projectHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{projectHours - hoursTotal} hours needed.");
            }
        }
    }
}
