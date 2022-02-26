using System;

namespace T04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string output = "";

            if (gender == "m")
            {
                if (age >= 16)
                {
                    output = "Mr.";
                }
                else
                {
                    output = "Master";
                }
            }
            else if (gender == "f")
            {
                if (age >= 16)
                {
                    output = "Ms.";
                }
                else
                {
                    output = "Miss";
                }
            }

            Console.WriteLine(output);
        }
    }
}
