using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void SignOfIntegerNumbers(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
            else if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SignOfIntegerNumbers(num);
        }
        
    }
}
