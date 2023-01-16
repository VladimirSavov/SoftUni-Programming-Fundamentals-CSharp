using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); ; 
            Regex name = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}");

            MatchCollection names = name.Matches(input);
            foreach (Match item in names)
            {
                Console.Write($"{item.Value} ");
            }

        }
    }
}
