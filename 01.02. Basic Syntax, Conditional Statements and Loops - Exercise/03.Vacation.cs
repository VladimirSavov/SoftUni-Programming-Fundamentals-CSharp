using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            if(type == "Students")
            {
                if(day == "Friday")
                {
                    price = 8.45 * countOfPeople;
                }
                else if(day == "Saturday")
                {
                    price = 9.80 * countOfPeople;
                }
                else if(day == "Sunday")
                {
                    price = 10.46 * countOfPeople;
                }
                if(countOfPeople >= 30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if(type == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }
                if (day == "Friday")
                {
                    price = 10.90 * countOfPeople;
                }
                else if (day == "Saturday")
                {
                    price = 15.60 * countOfPeople;
                }
                else if (day == "Sunday")
                {
                    price = 16 * countOfPeople;
                }
            }
            else if(type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15 * countOfPeople;
                }
                else if (day == "Saturday")
                {
                    price = 20 * countOfPeople;
                }
                else if (day == "Sunday")
                {
                    price = 22.50 * countOfPeople;
                }
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    price = price - (price * 0.05);
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
