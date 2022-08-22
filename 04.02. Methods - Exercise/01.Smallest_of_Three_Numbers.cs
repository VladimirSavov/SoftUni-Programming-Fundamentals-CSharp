using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestNumber());
        }
        static int SmallestNumber()
        {
            int[] number = new int[3];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(number);
            return number[0];
        }
    }
}
