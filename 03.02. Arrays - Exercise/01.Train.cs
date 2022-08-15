using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] passagers = new int[numberOfWagons];
            int totalPassagers = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                passagers[i] = int.Parse(Console.ReadLine());
                totalPassagers += passagers[i];
                Console.Write($"{passagers[i]} ");

            }
            Console.WriteLine();
            Console.Write(totalPassagers);
        }
    }
}
