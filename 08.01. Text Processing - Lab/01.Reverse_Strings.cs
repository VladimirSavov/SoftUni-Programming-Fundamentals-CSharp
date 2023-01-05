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
            while (input != "end")
            {
                string output = "";
                char[] inputReverse = input.ToCharArray();
                Array.Reverse(inputReverse);
                for (int i = 0; i < inputReverse.Length; i++)
                {
                    output += inputReverse[i];
                }
                Console.WriteLine($"{input} = {output}");
                input = Console.ReadLine();
            }
        }
    }
}
