using System;

namespace T04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double topStudents = 0;
            double between4and5 = 0;
            double between3and4 = 0;
            double fail = 0;
            double averageScore = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    fail++;
                }
                else if (grade < 4)
                {
                    between3and4++;
                }
                else if (grade < 5)
                {
                    between4and5++;
                }
                else
                {
                    topStudents++;
                }
                averageScore += grade;
            }

            double topStudentsPercent = topStudents / students * 100;
            double between4and5Percent = between4and5 / students * 100;
            double between3and4Percent = between3and4 / students * 100;
            double failPercent = fail / students * 100;
            averageScore /= students;

            Console.WriteLine($"Top students: {topStudentsPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4and5Percent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3and4Percent:f2}%");
            Console.WriteLine($"Fail: {failPercent:f2}%");
            Console.WriteLine($"Average: {averageScore:f2}");
        }
    }
}
