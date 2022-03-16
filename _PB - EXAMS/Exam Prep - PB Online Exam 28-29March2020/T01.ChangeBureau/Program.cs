using System;

namespace T01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double CNY = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double euro = bitcoins * 1168 / 1.95;
            euro += CNY * 0.15 * 1.76 / 1.95;
            euro -= euro * comission / 100;

            Console.WriteLine($"{euro:f2}");
        }
    }
}
