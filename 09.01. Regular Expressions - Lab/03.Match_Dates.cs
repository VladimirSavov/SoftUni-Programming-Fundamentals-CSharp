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
            string input = Console.ReadLine();  
            Regex name = new Regex(@"[0-9]{2}([\.\-\/])[A-Z][a-z]+\1[0-9]+");

            MatchCollection names = name.Matches(input);
            foreach (Match item in names)
            {
                string[] strings = item.Value.Split('.', '-', '/');
                Console.WriteLine($"Day: {strings[0]}, Month: {strings[1]}, Year: {strings[2]}");
            }

        }
    }
}
