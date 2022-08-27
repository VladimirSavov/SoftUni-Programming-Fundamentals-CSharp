using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isIntegerPalidrom = ReturnisNumberPalidrom(input);
                if (isIntegerPalidrom)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }       
        }
        static bool ReturnisNumberPalidrom(string input)
        {
            int number = int.Parse(input);
            if(number >= 0 && number <= 9)
            {
                return true;
            }
            if (input[0] == input[input.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}
