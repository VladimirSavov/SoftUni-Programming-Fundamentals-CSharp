using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                  number = number / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
