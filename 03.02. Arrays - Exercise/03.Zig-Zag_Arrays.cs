using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            int[] evenArray = new int[nLines];
            int[] oddArray = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArray));

            Console.WriteLine(String.Join(" ", oddArray));            
        }
    }
}
