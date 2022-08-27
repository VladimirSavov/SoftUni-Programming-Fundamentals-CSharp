using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            CenterPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void CenterPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstOne = Math.Abs(x1) + Math.Abs(y1);
            double secondOne = Math.Abs(x2) + Math.Abs(y2);
            double firstPair = firstOne + secondOne;
            double thirdOne = Math.Abs(x3) + Math.Abs(y3);
            double fourthOne = Math.Abs(x4) + Math.Abs(y4);
            double secondPair = thirdOne + fourthOne;
            if (secondPair <= firstPair)
            {
                if(firstOne <= secondOne)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (thirdOne <= fourthOne)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
