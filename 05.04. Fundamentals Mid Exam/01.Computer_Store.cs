using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productPrice = Console.ReadLine();
            double totalSumWithoutTaxes = 0;
            double taxes = 0;
            double totalSumWithDiscount = 0;

            while (productPrice != "special" && productPrice != "regular")
            {
                if(double.Parse(productPrice) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    productPrice = Console.ReadLine();
                    continue;
                }
                else if (double.Parse(productPrice) == 0)
                {
                    Console.WriteLine("Invalid order!");
                    productPrice = Console.ReadLine();
                    continue;
                }
                totalSumWithoutTaxes += double.Parse(productPrice);

                productPrice = Console.ReadLine();
            }
            taxes = totalSumWithoutTaxes * 0.20;
            if(productPrice == "special")
            {
                totalSumWithDiscount = (totalSumWithoutTaxes + taxes) * 0.9;
                Console.WriteLine($"\"Congratulations you've just bought a new computer!\r\nPrice without taxes: {totalSumWithoutTaxes:F2}$\r\nTaxes: {taxes:F2}$\r\n-----------\r\nTotal price: {totalSumWithDiscount:F2}$\"\r\n");
            }
            else if(productPrice == "regular")
            {
                Console.WriteLine($"\"Congratulations you've just bought a new computer!\r\nPrice without taxes: {totalSumWithoutTaxes:F2}$\r\nTaxes: {taxes:F2}$\r\n-----------\r\nTotal price: {totalSumWithoutTaxes + taxes:F2}$\"\r\n");

            }

        }
    }
}



