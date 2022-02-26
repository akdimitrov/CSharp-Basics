using System;

namespace T05.Number0_9ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string number = "";

            if (num == 1)
            {
                number = "one";
            }
            else if (num == 2)
            {
                number = "two";
            }
            else if (num == 3)
            {
                number = "three";
            }
            else if (num == 4)
            {
                number = "four";
            }
            else if (num == 5)
            {
                number = "five";
            }
            else if (num == 6)
            {
                number = "six";
            }
            else if (num == 7)
            {
                number = "seven";
            }
            else if (num == 8)
            {
                number = "eight";
            }
            else if (num == 9)
            {
                number = "nine";
            }
            else
            {
                number = "number too big";
            }
            Console.WriteLine(number);
        }
    }
}
