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
            string regex = @"\+359([ |-])2(\1)(\d{3})\1(\d{4})\b";

            MatchCollection matches = Regex.Matches(input, regex);

            List<string> matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
