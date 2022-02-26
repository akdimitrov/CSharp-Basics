using System;

namespace T13.Notifications
{
    class Program
    {
        static void ShowSuccessMessage(string operation, string message)
        {
            string line1 = $"Successfully executed {operation}.";
            Console.WriteLine(line1);
            Console.WriteLine(new string('=', line1.Length));
            Console.WriteLine($"{message}.");
            Console.WriteLine();
        }

        static void ShowWarningMessage(string message)
        {
            string line1 = $"Warning: {message}.";
            Console.WriteLine(line1);
            Console.WriteLine(new string('=', line1.Length));
            Console.WriteLine();
        }

        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            string line1 = $"Error: Failed to execute {operation}.";
            Console.WriteLine(line1);
            Console.WriteLine(new string('=', line1.Length));
            Console.WriteLine($"Reason: {message}.");
            Console.WriteLine($"Error code: {errorCode}.");
            Console.WriteLine();
        }

        static void ReadAndProcessMessage(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string messageType = Console.ReadLine();
                if (messageType == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccessMessage(operation, message);
                }
                else if (messageType == "warning")
                {
                    string message = Console.ReadLine();
                    ShowWarningMessage(message);
                }
                else if (messageType == "error")
                {
                    string opreration = Console.ReadLine();
                    string message = Console.ReadLine();
                    int errorCode = int.Parse(Console.ReadLine());
                    ShowErrorMessage(opreration, message, errorCode);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ReadAndProcessMessage(n);
        }
    }
}
