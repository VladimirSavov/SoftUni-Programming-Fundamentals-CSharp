using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] word = input.Split('@', '|', '#', '*').ToArray();
                Console.WriteLine($"{word[1]} is {word[3]} years old.");
            }
        }
    }
}
