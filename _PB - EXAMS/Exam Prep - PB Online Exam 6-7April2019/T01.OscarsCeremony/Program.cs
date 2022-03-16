using System;

namespace T01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statues = rent * 0.7;
            double catering = statues * 0.85;
            double sounding = catering * 0.5;
            double total = rent + statues + catering + sounding;

            Console.WriteLine($"{total:f2}");
        }
    }
}
