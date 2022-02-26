using System;

namespace T05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffeePrice = 0;
            double waterPrice = 0;
            double beerPrice = 0;
            double sweetsPrice = 0;
            double peanutsPrice = 0;

            if (city == "Sofia")
            {
                coffeePrice = quantity * 0.5;
                waterPrice = quantity * 0.8;
                beerPrice = quantity * 1.20;
                sweetsPrice = quantity * 1.45;
                peanutsPrice = quantity * 1.60;
            }
            else if (city == "Plovdiv")
            {
                coffeePrice = quantity * 0.4;
                waterPrice = quantity * 0.7;
                beerPrice = quantity * 1.15;
                sweetsPrice = quantity * 1.30;
                peanutsPrice = quantity * 1.50;
            }
            else if (city == "Varna")
            {
                coffeePrice = quantity * 0.45;
                waterPrice = quantity * 0.7;
                beerPrice = quantity * 1.10;
                sweetsPrice = quantity * 1.35;
                peanutsPrice = quantity * 1.55;
            }

            switch (product)
            {
                case "coffee": Console.WriteLine(coffeePrice); break;
                case "water": Console.WriteLine(waterPrice); break;
                case "beer": Console.WriteLine(beerPrice); break;
                case "sweets": Console.WriteLine(sweetsPrice); break;
                case "peanuts": Console.WriteLine(peanutsPrice); break;
            }
        }
    }
}
