using System;

namespace T14.NumbersToWords
{
    class Program
    {
        static void Letterize(int number)
        {
            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;
            string num = "";
            if (number < 0)
            {
                num = "minus ";
            }
            if (number < -999)
            {
                Console.WriteLine("too small");
                return;
            }
            else if (number > 999)
            {
                Console.WriteLine("too large");
                return;
            }
            else if (number > -100 && number < 100)
            {
                return;
            }
            else
            {
                number = Math.Abs(number);
                digit3 = number % 10;
                number /= 10;
                digit2 = number % 10;
                number /= 10;
                digit1 = number % 10;
            }

            switch (digit1)
            {
                case 1: num += "one-hundred"; break;
                case 2: num += "two-hundred"; break;
                case 3: num += "three-hundred"; break;
                case 4: num += "four-hundred"; break;
                case 5: num += "five-hundred"; break;
                case 6: num += "six-hundred"; break;
                case 7: num += "seven-hundred"; break;
                case 8: num += "eight-hundred"; break;
                case 9: num += "nine-hundred"; break;
            }

            if (digit2 > 0 || digit3 > 0)
            {
                num += " and ";
            }

            switch (digit2)
            {
                case 1:
                    switch (digit3)
                    {
                        case 0: num += "ten"; break;
                        case 1: num += "eleven"; break;
                        case 2: num += "twelve"; break;
                        case 3: num += "thirteen"; break;
                        case 4: num += "fourteen"; break;
                        case 5: num += "fifteen"; break;
                        case 6: num += "sixteen"; break;
                        case 7: num += "seventeen"; break;
                        case 8: num += "eighteen"; break;
                        case 9: num += "nineteen"; break;
                    }
                    break;
                case 2: num += "twenty"; break;
                case 3: num += "thirty"; break;
                case 4: num += "fourty"; break;
                case 5: num += "fifty"; break;
                case 6: num += "sixty"; break;
                case 7: num += "seventy"; break;
                case 8: num += "eighty"; break;
                case 9: num += "ninety"; break;
            }

            if (digit2 != 1)
            {
                if (digit2 > 1)
                {
                    num += " ";
                }
                switch (digit3)
                {
                    case 1: num += "one"; break;
                    case 2: num += "two"; break;
                    case 3: num += "three"; break;
                    case 4: num += "four"; break;
                    case 5: num += "five"; break;
                    case 6: num += "six"; break;
                    case 7: num += "seven"; break;
                    case 8: num += "eight"; break;
                    case 9: num += "nine"; break;
                }
            }

            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Letterize(number);
            }
        }
    }
}
