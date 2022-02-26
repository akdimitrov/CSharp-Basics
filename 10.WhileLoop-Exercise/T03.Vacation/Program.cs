using System;

namespace T03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyGoal = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int days = 0;

            while (money < moneyGoal && spendCounter < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    spendCounter++;
                    money -= amount;
                    if (money < 0)
                        money = 0;
                }
                else if (action == "save")
                {
                    money += amount;
                    spendCounter = 0;
                }

                days++;
            }

            if (spendCounter < 5)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
