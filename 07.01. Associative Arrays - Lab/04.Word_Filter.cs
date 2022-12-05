using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(s => s.Length % 2 == 0).ToArray();
            foreach (var item in words)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
