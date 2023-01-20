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
            string input = Console.ReadLine();
            Regex regex = new Regex(@".?%(?<name>[A-Z][a-z]+)%.?<(?<product>[A-z][a-z]+)>.?\|(?<count>[0-9]+)\|(?<price>[0-9]+).(?<prices>[0-9]+)\$");
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            double totalPrice = 0;
            while (input != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    string price = match.Groups[4].Value + "." + match.Groups[5].Value;
                    string dicKey = $"{name}: {product}";
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary.Add(dicKey, count * double.Parse(price));
                        totalPrice += count * double.Parse(price);
                    }
                    else
                    {
                        dictionary[dicKey] = count * double.Parse(price);
                        totalPrice += count * double.Parse(price);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value:F2}");
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
