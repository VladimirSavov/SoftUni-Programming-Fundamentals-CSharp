using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double lastNumber = 0.0;
            number /= 10;
            double sum = 0.0;
            while (number / 10 > 1)
            {
                lastNumber = number % 10;
                for (double i = lastNumber; i >= 1; i--)
                {
                    sum *= i;
                }
                number /= 10;
            }
            if(sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
