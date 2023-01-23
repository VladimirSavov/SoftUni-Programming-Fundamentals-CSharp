using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringLength = 0;
            string input = Console.ReadLine();
            List<string> output = new List<string>();
            Regex reg = new Regex(@"(=|\/)(?<destination>[A-Z][a-z]{2,})\1");
            MatchCollection matches = reg.Matches(input);
            foreach (Match city in matches)
            {
                string cityValue = city.Groups["destination"].Value;
                stringLength += cityValue.Length;
                output.Add(cityValue);
            }
            Console.Write("Destinations: ");
            Console.Write(string.Join(", ", output));
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {stringLength}");
        }
    }
}
