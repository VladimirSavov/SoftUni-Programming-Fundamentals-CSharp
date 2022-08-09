using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                sum += (int)digit;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
