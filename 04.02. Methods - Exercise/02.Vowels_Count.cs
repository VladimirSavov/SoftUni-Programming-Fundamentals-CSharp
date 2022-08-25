using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();


            Console.WriteLine(VowelsCount(input));
        }

        static int VowelsCount(string input)
        {
            char[] letters = input.ToCharArray();

            int counter = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'a' || letters[i] == 'u' || letters[i] == 'e' || letters[i] == 'o' || letters[i] == 'i' || letters[i] == 'y')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
