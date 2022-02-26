using System;

namespace T12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = sales;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500) comission *= 0.05;
                else if (sales <= 1000) comission *= 0.07;
                else if (sales <= 10000) comission *= 0.08;
                else if (sales > 10000) comission *= 0.12;
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500) comission *= 0.045;
                else if (sales <= 1000) comission *= 0.075;
                else if (sales <= 10000) comission *= 0.10;
                else if (sales > 10000) comission *= 0.13;
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500) comission *= 0.055;
                else if (sales <= 1000) comission *= 0.08;
                else if (sales <= 10000) comission *= 0.12;
                else if (sales > 10000) comission *= 0.145;
            }

            if (comission != sales && comission > 0)
                Console.WriteLine($"{comission:f2}");
            else
                Console.WriteLine("error");
        }
    }
}
