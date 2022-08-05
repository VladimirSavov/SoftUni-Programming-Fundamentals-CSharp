using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            if(number % 10 == 0)
            {
                result = 10;
                Console.WriteLine($"The number is divisible by {result}");
            }
            else if(number % 7 == 0)
            {
                result = 7;
                Console.WriteLine($"The number is divisible by {result}");
            }
            else if (number % 6 == 0)
            {
                result = 6;
                Console.WriteLine($"The number is divisible by {result}");
            }
            else if (number % 3 == 0)
            {
                result = 3;
                Console.WriteLine($"The number is divisible by {result}");
            }
            else if (number % 2 == 0)
            {
                result = 2;
                Console.WriteLine($"The number is divisible by {result}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
