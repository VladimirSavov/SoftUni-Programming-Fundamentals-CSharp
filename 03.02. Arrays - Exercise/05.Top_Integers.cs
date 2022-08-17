using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < input.Length; i++)
            {
                bool isBigger = true;
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (input[i] <= input[k])
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
