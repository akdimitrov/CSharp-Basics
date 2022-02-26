using System;

namespace T05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensTotal = pens * 5.80;
            double markersTotal = markers * 7.20;
            double detergentTotal = detergent * 1.20;
            double discountTotal = (pensTotal + markersTotal + detergentTotal) * discount / 100;
            double finalSum = pensTotal + markersTotal + detergentTotal - discountTotal;

            Console.WriteLine(finalSum);



        }
    }
}
