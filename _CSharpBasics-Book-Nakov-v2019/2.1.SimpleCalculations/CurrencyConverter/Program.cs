using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double USD_COURSE = 1.79549;
            const double EUR_COURSE = 1.95583;
            const double GBP_COURSE = 2.53405;

            double sum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            switch (inputCurrency)
            {
                case "USD": sum = sum * USD_COURSE; break;
                case "EUR": sum = sum * EUR_COURSE; break;
                case "GBP": sum = sum * GBP_COURSE; break;
            }

            switch (outputCurrency)
            {
                case "USD": sum = sum / USD_COURSE; break;
                case "EUR": sum = sum / EUR_COURSE; break;
                case "GBP": sum = sum / GBP_COURSE; break;
            }

            Console.WriteLine($"{sum:f2} {outputCurrency}");
        }
    }
}
