using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            int addOperation = numberOne + numberTwo;
            int divideOperation = addOperation / numberThree;
            int multiplyOperation = divideOperation * numberFour;

            Console.WriteLine(multiplyOperation);
        }
    }
}
