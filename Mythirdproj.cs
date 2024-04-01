using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Converter");
            Console.WriteLine("1. Seconds to Minutes");
            Console.WriteLine("2. Minutes to Hours");
            Console.WriteLine("3. Hours to Days");
            Console.WriteLine("4. Days to Months");
            Console.Write("Enter your choice (1-4): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter seconds: ");
                    int seconds = int.Parse(Console.ReadLine());
                    double minutes = seconds / 60.0;
                    Console.WriteLine($"{seconds} seconds = {minutes} minutes");
                    break;
                case 2:
                    Console.Write("Enter minutes: ");
                    int minutesInput = int.Parse(Console.ReadLine());
                    double hours = minutesInput / 60.0;
                    Console.WriteLine($"{minutesInput} minutes = {hours} hours");
                    break;
                case 3:
                    Console.Write("Enter hours: ");
                    int hoursInput = int.Parse(Console.ReadLine());
                    double days = hoursInput / 24.0;
                    Console.WriteLine($"{hoursInput} hours = {days} days");
                    break;
                case 4:
                    Console.Write("Enter days: ");
                    int daysInput = int.Parse(Console.ReadLine());
                    double months = daysInput / 30.0; 
                    Console.WriteLine($"{daysInput} days = {months} months");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadLine(); 
        }
    }
}