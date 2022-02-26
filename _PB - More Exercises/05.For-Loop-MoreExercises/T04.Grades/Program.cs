using System;

namespace T04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double poor = 0;
            double mid = 0;
            double average = 0;
            double top = 0;
            double gradeSum = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;

                if (grade < 3)
                {
                    poor++;
                }
                else if (grade < 4)
                {
                    average++;
                }
                else if (grade < 5)
                {
                    mid++;
                }
                else
                {
                    top++;
                }
            }

            Console.WriteLine($"Top students: {top / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {mid / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {average / students * 100:f2}%");
            Console.WriteLine($"Fail: {poor / students * 100:f2}%");
            Console.WriteLine($"Average: {gradeSum / students:f2}");
        }
    }
}
