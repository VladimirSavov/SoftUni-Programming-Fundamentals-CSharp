using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int k = 0; k < word[i].Length; k++)
                {
                    Console.Write(word[i]);
                }
            }
        }
    }
}
