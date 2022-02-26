using System;

namespace T09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeLitres = (a * b * c) / 1000.0;
            double litresCappacity = volumeLitres - volumeLitres * percent / 100;

            Console.WriteLine(litresCappacity);
        }
    }
}
