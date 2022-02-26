using System;

namespace T15._StringEncryption
{
    class Program
    {
        static string Encrypt(char letter)
        {
            int charInt = (int)letter;
            char symbol1 = ' ';
            int digit1 = 0;
            int digit2 = 0;
            char symbol2 = ' ';
            if (charInt < 10)
            {
                digit2 = charInt;
                digit1 = charInt;
            }
            else if (letter < 100)
            {
                digit2 = charInt % 10;
                charInt /= 10;
                digit1 = charInt % 10;
            }
            else
            {
                digit2 = charInt % 10;
                charInt /= 100;
                digit1 = charInt % 10;
            }

            symbol1 = (char)(letter + digit2);
            symbol2 = (char)(letter - digit1);

            return $"{symbol1}{digit1}{digit2}{symbol2}";
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                result += Encrypt(symbol);
            }
            Console.WriteLine(result);
        }
    }
}
