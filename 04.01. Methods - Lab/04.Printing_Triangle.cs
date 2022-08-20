using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
            for (int j = number; j >= 1; j--)
            {
                for (int l = 1; l < j; l++)
                {
                    Console.Write($"{l} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
        
    }
}
