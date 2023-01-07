using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int n = input[i] + 3;
                char c = (char)n;
                output += c;
            }
            Console.WriteLine(output);
        }
    }
}
