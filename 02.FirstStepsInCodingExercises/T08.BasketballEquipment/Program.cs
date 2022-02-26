using System;

namespace T08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakers = annualFee * 0.60;
            double outfit = sneakers * 0.80;
            double basketball = outfit * 0.25;
            double accessories = basketball * 0.20;
            double total = sneakers + outfit + basketball + accessories;

            Console.WriteLine(annualFee + total);
        }
    }
}
