using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED = 26;
            const int MINIMUM = 100;
            const int DAILY_DECREES = 10;
            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0;

            while (countOfSpices >= MINIMUM)
            {
                totalConsumed += countOfSpices - CONSUMED;
                countOfSpices -= DAILY_DECREES;
                daysCounter++;
                if (countOfSpices < MINIMUM)
                {
                    totalConsumed -= CONSUMED;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);
        }
    }
}
