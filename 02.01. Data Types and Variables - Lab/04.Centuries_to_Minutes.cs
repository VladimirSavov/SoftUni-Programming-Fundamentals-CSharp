using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes");
        }
    }
}
