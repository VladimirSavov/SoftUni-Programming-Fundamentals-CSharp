using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintMiddleCharacters(word);
            
        }
        static void PrintMiddleCharacters(string word)
        {
            if(word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
            else
            {
                Console.Write(word[(word.Length / 2) - 1]);
                Console.Write(word[word.Length / 2]);
            }
            Console.WriteLine();
        }
    }
}
