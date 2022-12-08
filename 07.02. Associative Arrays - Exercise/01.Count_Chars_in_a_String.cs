using System;
using System.Collections.Generic;
using System.Linq;



namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var letters in word)
            {
                if (letters != ' ')
                {
                    if (dic.ContainsKey(letters))
                    {
                        dic[letters]++;
                    }
                    else
                    {
                        dic.Add(letters, 1);
                    }
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
