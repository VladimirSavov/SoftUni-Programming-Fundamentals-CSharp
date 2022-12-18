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
            var data = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "register")
                {
                    if (!data.ContainsKey(input[1]))
                    {
                        data.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {data[input[1]]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (data.ContainsKey(input[1]))
                    {
                        data.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
