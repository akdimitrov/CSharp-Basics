using System;

namespace T05.DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double dailyWage = double.Parse(Console.ReadLine());
            double USDToBGN = double.Parse(Console.ReadLine());

            double annualSalary = workingDaysPerMonth * dailyWage * 12;
            double bonus = annualSalary / 12 * 2.5;
            double annualNetIncome = (annualSalary + bonus) * 0.75;
            double dailyNetWage = annualNetIncome / 365;

            Console.WriteLine($"{dailyNetWage * USDToBGN:f2}");
        }
    }
}
