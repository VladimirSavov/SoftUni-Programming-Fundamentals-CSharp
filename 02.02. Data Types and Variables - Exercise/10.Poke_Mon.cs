using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int power = N;
            int counter = 0;

            while (power >= M)
            {
                power -= M;
                counter++;
                if (N * 0.5 == power && Y > 0)
                {
                    power /= Y;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
