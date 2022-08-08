using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            int freeBelts = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                if(i % 6 == 0)
                {
                    freeBelts++;
                }
                
            }
            totalPrice = priceOfLightsabers * (countOfStudents + (Math.Ceiling(countOfStudents * 0.1))) + (priceOfRobes * countOfStudents) + (priceOfBelts * (countOfStudents - freeBelts));
            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else if(amountOfMoney < totalPrice)
            {
                Console.WriteLine($" John will need {totalPrice - amountOfMoney:F2}lv more.");
            }
        }
    }
}
