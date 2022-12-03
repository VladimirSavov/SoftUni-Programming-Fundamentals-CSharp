using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = Console.ReadLine().Split().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToLower();
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                string word = list[i]; 
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 0);
                }
                dict[word]++;
            }
            foreach (var item in dict)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key.ToLower()} ");
                }
            }
        }  
    }
}
