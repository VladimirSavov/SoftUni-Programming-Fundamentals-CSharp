using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ").ToArray();
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            while (input[0] != "End")
            {
                string nameOfCompany = input[0];
                string userId = input[1];
                if (output.ContainsKey(nameOfCompany))
                {
                    if (output[nameOfCompany].Contains(userId))
                    {
                        input = Console.ReadLine().Split(" -> ").ToArray();
                        continue;
                    }
                    output[nameOfCompany].Add(userId);
                }
                else
                {
                    output.Add(nameOfCompany, new List<string>() { userId });
                }
                input = Console.ReadLine().Split(" -> ").ToArray();
            }
            foreach (var item in output)
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
