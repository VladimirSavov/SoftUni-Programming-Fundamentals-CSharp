using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };
            int number = int.Parse(Console.ReadLine());
            if(number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekdays[number - 1]);

            }
        }
    }
}
