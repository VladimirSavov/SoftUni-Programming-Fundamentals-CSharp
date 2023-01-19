using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            string fullPrice = "";
            Regex regex = new Regex(@">>(?<furnitureName>[A-Za-z]+)<<(?<price>[0-9]+)(?<price1>\.[0-9]+)?!(?<quantity>[0-9]+)");
            List<string> boughtFurniture = new List<string>();
            while(input != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furnitureName = match.Groups[1].Value;
                    string price = match.Groups[2].Value;
                    string prices = match.Groups[3].Value;
                    int quantity = int.Parse(match.Groups[4].Value);
                    if(prices != null)
                    {
                        fullPrice = price + prices;
                        totalPrice += double.Parse(fullPrice) * quantity;
                    }
                    else
                    {
                        totalPrice += int.Parse(price) * quantity;
                    }
                    boughtFurniture.Add(furnitureName);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in boughtFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total mooney spend: {totalPrice}");
        }
    }
}
