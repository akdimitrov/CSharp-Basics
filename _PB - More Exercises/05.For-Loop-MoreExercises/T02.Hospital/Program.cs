using System;

namespace T02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int doctors = 7;
            int untretedPatients = 0;
            int treatedPatients = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && untretedPatients > treatedPatients)
                    doctors++;

                int newPatients = int.Parse(Console.ReadLine());

                if (newPatients <= doctors)
                    treatedPatients += newPatients;
                else
                {
                    untretedPatients += newPatients - doctors;
                    treatedPatients += doctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untretedPatients}.");
        }
    }
}
