using System;

namespace T01.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinutes;
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinutes;

            int timeDifference = examTimeInMinutes - arrivalTimeInMinutes;
            int hours = Math.Abs(timeDifference / 60);
            int minutes = Math.Abs(timeDifference % 60);

            if (timeDifference <= 30 && timeDifference >= 0)
            {
                Console.WriteLine("On time");
                if (timeDifference != 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (timeDifference > 30)
            {
                Console.WriteLine("Early");
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
