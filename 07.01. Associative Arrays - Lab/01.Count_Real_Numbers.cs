using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> doubleOccurrances = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!doubleOccurrances.ContainsKey(numbers[i]))
                {
                    doubleOccurrances.Add(numbers[i], 0);
                }
                doubleOccurrances[numbers[i]]++;
            }

            foreach (var item in doubleOccurrances)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }  
    }
}
