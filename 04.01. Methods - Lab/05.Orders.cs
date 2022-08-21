using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
      
        static void PrintOrder(string product, int quantity)
        {
            double price = 0;
            if(product == "coffee")
            {
                price = 1.5 * quantity;
            }
            else if (product == "water")
            {
                price = 1 * quantity;
            }
            else if (product == "coke")
            {
                price = 1.4 * quantity;
            }
            else if (product == "snacks")
            {
                price = 2 * quantity;
            }
            Console.WriteLine("{0:F2}", price);
        }
       
        static void Main(string[] args)
        {
            PrintOrder(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        
    }
}
