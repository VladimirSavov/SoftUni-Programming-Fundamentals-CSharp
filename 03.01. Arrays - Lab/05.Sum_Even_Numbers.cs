using System;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] number = new int[input.Length];
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (number[i] % 2 == 0) 
                { 
                    sum += number[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
