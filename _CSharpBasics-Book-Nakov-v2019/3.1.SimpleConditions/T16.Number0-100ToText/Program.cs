using System;

namespace T16.Number0_100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string doubleNumText = "";
            string singleNumText = "";

            if (num < 0 || num > 100) Console.WriteLine("invalid number");
            else if (num < 20)
            {
                if (num == 0) Console.WriteLine("zero");
                else if (num == 1) Console.WriteLine("one");
                else if (num == 2) Console.WriteLine("two");
                else if (num == 3) Console.WriteLine("three");
                else if (num == 4) Console.WriteLine("four");
                else if (num == 5) Console.WriteLine("five");
                else if (num == 6) Console.WriteLine("six");
                else if (num == 7) Console.WriteLine("seven");
                else if (num == 8) Console.WriteLine("eight");
                else if (num == 9) Console.WriteLine("nine");
                else if (num == 10) Console.WriteLine("ten");
                else if (num == 11) Console.WriteLine("eleven");
                else if (num == 12) Console.WriteLine("twelve");
                else if (num == 13) Console.WriteLine("thirteen");
                else if (num == 14) Console.WriteLine("fourteen");
                else if (num == 15) Console.WriteLine("fifteen");
                else if (num == 16) Console.WriteLine("sixteen");
                else if (num == 17) Console.WriteLine("seventeen");
                else if (num == 18) Console.WriteLine("eighteen");
                else if (num == 19) Console.WriteLine("nineteen");
            }
            else if (num < 100)
            {
                int doubleNum = num / 10;
                int singleNum = num % 10;

                if (doubleNum == 2) doubleNumText = "twenty";
                else if (doubleNum == 3) doubleNumText = "thirty";
                else if (doubleNum == 4) doubleNumText = "forty";
                else if (doubleNum == 5) doubleNumText = "fifty";
                else if (doubleNum == 6) doubleNumText = "sixty";
                else if (doubleNum == 7) doubleNumText = "seventy";
                else if (doubleNum == 8) doubleNumText = "eighty";
                else if (doubleNum == 9) doubleNumText = "ninety";

                if (singleNum == 1) singleNumText = "one";
                else if (singleNum == 2) singleNumText = "two";
                else if (singleNum == 3) singleNumText = "three";
                else if (singleNum == 4) singleNumText = "four";
                else if (singleNum == 5) singleNumText = "five";
                else if (singleNum == 6) singleNumText = "six";
                else if (singleNum == 7) singleNumText = "seven";
                else if (singleNum == 8) singleNumText = "eight";
                else if (singleNum == 9) singleNumText = "nine";

                if (singleNumText == "") Console.WriteLine(doubleNumText);
                else Console.WriteLine(doubleNumText + " " + singleNumText);
            }
            else Console.WriteLine("one hundred");
        }
    }
}
