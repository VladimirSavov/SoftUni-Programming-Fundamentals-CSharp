using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();
            while (input[0] != "buy")
            {
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, price);
                    newOrders.Add(name, quantity);
                }
                else
                {
                    orders.Remove(name);
                    orders.Add(name, price);
                    newOrders[name] += quantity;
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in newOrders)
            {
                foreach (var element in orders)
                {
                    if(element.Key == item.Key)
                    {
                        Console.WriteLine($"{element.Key} -> {element.Value * item.Value:F2}");
                    }
                }
            }
        }
    }
}
