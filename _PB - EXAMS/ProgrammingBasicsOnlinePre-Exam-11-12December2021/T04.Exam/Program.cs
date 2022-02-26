using System;

namespace T04.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double gradeSum = 0;
            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;

                if (grade >= 2 && grade < 3)
                {
                    p1++;
                }
                else if (grade < 4)
                {
                    p2++;
                }
                else if (grade < 5)
                {
                    p3++;
                }
                else
                {
                    p4++;
                }
            }

            Console.WriteLine($"Top students: {p4 * 100 / students:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {p3 * 100 / students:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {p2 * 100 / students:f2}%");
            Console.WriteLine($"Fail: {p1 * 100 / students:f2}%");
            Console.WriteLine($"Average: {gradeSum / students:f2}");
        }
    }
}
