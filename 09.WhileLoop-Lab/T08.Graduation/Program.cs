using System;

namespace T08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int fails = 0;
            int year = 1;
            double gradeSum = 0;

            while (fails < 2 && year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    fails++;
                }
                else
                {
                    year++;
                    gradeSum += grade;
                }
            }

            if (fails < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeSum / 12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
        }
    }
}
