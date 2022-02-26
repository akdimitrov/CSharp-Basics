using System;

namespace T12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            string password = "";

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            if (num1 < num2 && num3 > num4 && (num1 * num2 + num3 * num4 == number))
                            {
                                counter++;
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                                if (counter == 4)
                                {
                                    password = $"{num1}{num2}{num3}{num4}";
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (password == "")
            {
                Console.Write("No!");
            }
            else
            {
                Console.Write($"Password: {password}");
            }
        }
    }
}
