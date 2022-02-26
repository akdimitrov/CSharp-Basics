﻿using System;

namespace T09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum += n % 10;
                n /= 10;
            }
            while (n > 0);

            Console.WriteLine(sum);
        }
    }
}
