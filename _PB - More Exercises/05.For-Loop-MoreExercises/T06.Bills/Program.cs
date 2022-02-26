using System;

namespace T06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int waterTotal = 20 * months;
            int internetTotal = 15 * months;
            double electricityTotal = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityTotal += electricity;
            }

            double other = (electricityTotal + waterTotal + internetTotal) * 1.2;
            double totalExpenses = electricityTotal + waterTotal + internetTotal + other;
            double average = totalExpenses / months;

            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTotal:f2} lv");
            Console.WriteLine($"Internet: {internetTotal:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
