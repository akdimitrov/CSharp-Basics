using System;

namespace T04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            const double EURO_COURSE = 1.94;
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());

            double totalPrice = (vegetablesPrice * vegetablesWeight + fruitsPrice * fruitsWeight) / EURO_COURSE;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
