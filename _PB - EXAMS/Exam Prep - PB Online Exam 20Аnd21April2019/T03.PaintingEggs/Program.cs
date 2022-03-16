using System;

namespace T03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColor = Console.ReadLine();
            int batches = int.Parse(Console.ReadLine());
            double batchPrice = 0;

            if (eggSize == "Large")
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 16; break;
                    case "Green": batchPrice = 12; break;
                    case "Yellow": batchPrice = 9; break;
                }
            }
            else if (eggSize == "Medium")
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 13; break;
                    case "Green": batchPrice = 9; break;
                    case "Yellow": batchPrice = 7; break;
                }
            }
            else
            {
                switch (eggColor)
                {
                    case "Red": batchPrice = 9; break;
                    case "Green": batchPrice = 8; break;
                    case "Yellow": batchPrice = 5; break;
                }
            }

            double income = batchPrice * batches * 0.65;
            Console.WriteLine($"{income:f2} leva.");
        }
    }
}
