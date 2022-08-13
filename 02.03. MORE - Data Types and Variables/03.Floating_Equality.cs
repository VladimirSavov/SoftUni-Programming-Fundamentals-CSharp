using System;
namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = (double.Parse(Console.ReadLine()));
            double secondNumber = (double.Parse(Console.ReadLine()));
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;

            Console.WriteLine(equal);
        }
    }
}
