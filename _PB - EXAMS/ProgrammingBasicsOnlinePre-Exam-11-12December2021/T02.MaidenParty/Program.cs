using System;

namespace T02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyHolders = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int fortuneSurprise = int.Parse(Console.ReadLine());

            double totalProfit = loveMessages * 0.60 + roses * 7.20 + keyHolders * 3.60 + caricatures * 18.20 + fortuneSurprise * 22.00;
            int totalItems = loveMessages + roses + keyHolders + caricatures + fortuneSurprise;

            if (totalItems >= 25)
            {
                totalProfit *= 0.65;
            }

            totalProfit *= 0.9;

            if (partyPrice <= totalProfit)
            {
                Console.WriteLine($"Yes! {totalProfit - partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - totalProfit:f2} lv needed.");
            }
        }
    }
}
