using System;
using System.Collections.Generic;
using System.Linq;



namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            int counter = 1;
            string resourse = "";
            int quantity = 0;
            while (input != "stop")
            {
                if(counter % 2 != 0)
                {
                    resourse = input;
                }
                else
                {
                    quantity = int.Parse(input);
                    if (dictionary.ContainsKey(resourse))
                    {
                        dictionary[resourse] += quantity;
                    }
                    else
                    {
                    dictionary.Add(resourse, quantity);
                    }
                }
                counter++;
                input = Console.ReadLine();
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
