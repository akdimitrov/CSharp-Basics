using System;

namespace T02.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());

            double veggieTotalPrice = vegetablesPrice * vegetablesWeight;
            double fruitsTotalPrice = fruitsPrice * fruitsWeight;
            double finalPrice = veggieTotalPrice + fruitsTotalPrice;
            double finalPriceInEURO = finalPrice / 1.94;

            Console.WriteLine(finalPriceInEURO);
        }
    }
}
