using System;
using System.Collections.Generic;
using System.Numerics;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            number *= n;
            Console.WriteLine(number);
        }
        
    }
}
