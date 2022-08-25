using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result1 = Factorial(firstNum);
            double result2 = Factorial(secondNum);
            Console.WriteLine($"{result1 / result2:F2}");
        }
        static double Factorial(int number)
        {
            double result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
