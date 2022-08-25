using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int addResult = PrintAdd(number1, number2);
            Console.WriteLine(Subtract(addResult, number3));
        }
        static int PrintAdd(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Subtract(int result, int number3)
        {
            return result - number3;
        }
    }
}
