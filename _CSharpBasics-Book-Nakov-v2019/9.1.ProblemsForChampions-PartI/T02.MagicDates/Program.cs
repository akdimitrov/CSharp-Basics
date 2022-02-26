using System;

namespace T02.MagicDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearStart = int.Parse(Console.ReadLine());
            int yearEnd = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            bool found = false;

            for (int year = yearStart; year <= yearEnd; year++)
            {
                bool isLeap = false;
                if (year % 4 == 0)
                {
                    isLeap = true;
                }
                int currentYear = year;
                int year4 = currentYear % 10;
                currentYear /= 10;
                int year3 = currentYear % 10;
                currentYear /= 10;
                int year2 = currentYear % 10;
                currentYear /= 10;
                int year1 = currentYear % 10;

                for (int month = 1; month <= 12; month++)
                {
                    int currentMonth = month;
                    int month2 = currentMonth % 10;
                    currentMonth /= 10;
                    int month1 = currentMonth % 10;

                    for (int day = 1; day <= 31; day++)
                    {
                        if (isLeap && month == 2 && day > 29)
                        {
                            break;
                        }
                        else if (!isLeap && month == 2 && day > 28)
                        {
                            break;
                        }

                        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                        {
                            break;
                        }
                        int currentDay = day;
                        int day2 = currentDay % 10;
                        currentDay /= 10;
                        int day1 = currentDay % 10;

                        int currentWeight = day1 * (day2 + month1 + month2 + year1 + year2 + year3 + year4)
                            + day2 * (month1 + month2 + year1 + year2 + year3 + year4)
                            + month1 * (month2 + year1 + year2 + year3 + year4)
                            + month2 * (year1 + year2 + year3 + year4)
                            + year1 * (year2 + year3 + year4)
                            + year2 * (year3 + year4)
                            + year3 * year4;

                        if (currentWeight == weight)
                        {
                            found = true;
                            Console.WriteLine($"{day:d2}-{month:d2}-{year}");
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
