using System;

namespace T06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = paint * 14.50 * 1.1;
            double thinnerPrice = thinner * 5.00;
            double plasticBags = 0.40;
            double totalSum = (nylonPrice + paintPrice + thinnerPrice + plasticBags);
            double labourExpences = hours * (totalSum * 0.3);

            Console.WriteLine(totalSum + labourExpences);
        }
    }
}
