using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(Multiplied(words[0], words[1]));
        }
        static int Multiplied(string firstWord, string secondWord)
        {
            int[] firstWordArray = new int[firstWord.Length];
            int[] secondWordArray = new int[secondWord.Length];
            int difference = 0;
            int sum = 0;
            if(firstWord.Length >= secondWord.Length)
            {
                difference = firstWord.Length - secondWord.Length;
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                for (int i = 0; i < difference; i++)
                {
                    sum += firstWord[firstWord.Length - i];
                }
            }
            else
            {
                difference = secondWord.Length - firstWord.Length;
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                for (int i = 0; i < difference; i++)
                {
                    sum += secondWord[secondWord.Length - 1 - i];
                }
            }
            return sum;
        }
    }
}
