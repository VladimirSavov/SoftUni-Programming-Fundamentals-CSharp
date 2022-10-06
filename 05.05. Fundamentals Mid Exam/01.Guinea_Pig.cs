using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityHay = double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double quantityWeight = double.Parse(Console.ReadLine()) * 1000;
            int dayCount = 1;
            while (quantityFood > 0 && quantityHay > 0 && quantityCover > 0)
            {
                quantityFood -= 300;
                if(dayCount % 2 == 0)
                {
                    quantityHay -= quantityFood * 0.05;
                }
                if(dayCount % 3 == 0)
                {
                    quantityCover -= quantityWeight * 0.333;
                }
                dayCount++;
                if(dayCount == 31)
                {
                    break;
                }
            }
            if(quantityFood > 0 && quantityHay > 0 && quantityCover > 0)
            {
                quantityFood /= 1000;
                quantityCover /= 1000;
                quantityHay /= 1000;
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood:F2}, Hay: {quantityHay:F2}, Cover: {quantityCover:F2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
        }
    }
}

