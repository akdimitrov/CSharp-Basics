using System;

namespace T10.StringRepeater
{
    class Program
    {
        static string RepeatString(string text, int n)
        {
            string repeatedString = "";
            for (int i = 0; i < n; i++)
            {
                repeatedString += text;
            }

            return repeatedString;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, n));
        }
    }
}
