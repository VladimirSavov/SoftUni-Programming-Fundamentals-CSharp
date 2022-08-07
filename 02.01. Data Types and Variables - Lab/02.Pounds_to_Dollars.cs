using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            double kilometers = input * 1.31;
            Console.WriteLine("{0:F3}", kilometers);
        }
    }
}
