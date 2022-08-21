using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
      
        static void PrintRectangleArea(int length, int height)
        {
            double rectangleArea = length * height;
            Console.WriteLine(rectangleArea);
        }
       
        static void Main(string[] args)
        {
            PrintRectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        
    }
}
