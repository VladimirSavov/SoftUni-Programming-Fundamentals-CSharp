using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int countOfOddNumber = 1 + (i * 2);
                Console.WriteLine(countOfOddNumber);
                    sum += countOfOddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
