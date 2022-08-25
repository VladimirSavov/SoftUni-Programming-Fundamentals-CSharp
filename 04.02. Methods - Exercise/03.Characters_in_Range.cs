using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharactersInRange(char1, char2);
        }
        static void CharactersInRange(char symbol1, char symbol2)
        {
           int startChar = Math.Min(symbol1, symbol2);
           int endChar = Math.Max(symbol1, symbol2);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
