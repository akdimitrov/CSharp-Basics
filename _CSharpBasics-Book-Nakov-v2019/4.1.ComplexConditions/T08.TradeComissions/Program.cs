using System;

namespace T08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;
            bool isValid = true;

            if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia": comission = sales * 0.12; break;
                    case "Varna": comission = sales * 0.13; break;
                    case "Plovdiv": comission = sales * 0.145; break;
                    default: isValid = false; break;
                }
            }
            else if (sales > 1000)
            {
                switch (city)
                {
                    case "Sofia": comission = sales * 0.08; break;
                    case "Varna": comission = sales * 0.10; break;
                    case "Plovdiv": comission = sales * 0.12; break;
                    default: isValid = false; break;
                }
            }
            else if (sales > 500)
            {
                switch (city)
                {
                    case "Sofia": comission = sales * 0.07; break;
                    case "Varna": comission = sales * 0.075; break;
                    case "Plovdiv": comission = sales * 0.08; break;
                    default: isValid = false; break;
                }
            }
            else if (sales >= 0)
            {
                switch (city)
                {
                    case "Sofia": comission = sales * 0.05; break;
                    case "Varna": comission = sales * 0.045; break;
                    case "Plovdiv": comission = sales * 0.055; break;
                    default: isValid = false; break;
                }
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
