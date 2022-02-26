using System;

namespace T07.GreaterOfTwoValues
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int max = GetMax(num1, num2);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char max = GetMax(char1, char2);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string max = GetMax(text1, text2);
                Console.WriteLine(max);
            }
        }
    }
}
