using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            int n = input.IndexOf(key);
            while (n >= 0)
            {
                input = input.Remove(n, key.Length);
                n = input.IndexOf(key);
            }
            Console.WriteLine(input);
        }
    }
}
