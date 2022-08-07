using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            double kilometers = (double)input / 1000;
            Console.WriteLine("{0:F2}", kilometers);
        }
    }
}
