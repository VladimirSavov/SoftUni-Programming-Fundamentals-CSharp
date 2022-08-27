using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input == "int")
            {
                Console.WriteLine(Integer(int.Parse(Console.ReadLine())));
            }
            else if(input == "real")
            {
                double result = Real(double.Parse(Console.ReadLine()));
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine(String(Console.ReadLine()));
            }
        }
        static int Integer(int input)
        {
            return input * 2;
        }
        static double Real(double input)
        {
            return input * 1.5;
        }
        static string String(string input)
        {
            return ($"${input}$");
        }
    }
}
