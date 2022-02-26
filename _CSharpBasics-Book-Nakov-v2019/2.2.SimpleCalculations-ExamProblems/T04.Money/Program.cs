using System;

namespace T04.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double UANs = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            int bitcoinsInBGN = bitcoins * 1168;
            double UANsInBGN = UANs * 0.15 * 1.76;
            double totalInEURO = (bitcoinsInBGN + UANsInBGN) / 1.95;
            double finalSum = totalInEURO * ((100 - commission) / 100);

            Console.WriteLine(finalSum);
        }
    }
}
