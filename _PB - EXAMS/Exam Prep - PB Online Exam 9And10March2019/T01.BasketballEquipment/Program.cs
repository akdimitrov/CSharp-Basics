using System;

namespace T01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double sneakersPrice = annualFee * 0.6;
            double outfitPrice = sneakersPrice * 0.8;
            double ballPrice = outfitPrice / 4;
            double accessoriesPrice = ballPrice / 5;
            double totalPrice = annualFee + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
