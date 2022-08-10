using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= nLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                total += input; 
                if(total > CAPACITY)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    total -= input;
                }
            }
            Console.WriteLine(total);
        }
    }
}
