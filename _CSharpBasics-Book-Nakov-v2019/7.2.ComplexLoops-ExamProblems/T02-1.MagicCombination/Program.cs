using System;

namespace T02_1.MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                string num = i.ToString();
                int number = 1;
                for (int j = 0; j < num.Length; j++)
                {
                    int digit = int.Parse(num[j].ToString());
                    number *= digit;
                }
                if (number == magicNum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
