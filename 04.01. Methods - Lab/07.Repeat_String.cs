using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
      
        static void PrintRepeatString(string input, int n)
        {
            string output = "";
            for (int i = 0; i < n; i++)
            {
                output += input;
            }
            Console.WriteLine(output);
        }
       
        static void Main(string[] args)
        {
            PrintRepeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        
    }
}
