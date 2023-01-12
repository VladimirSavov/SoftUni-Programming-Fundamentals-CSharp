using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(">").ToList();
            List<string> newStrings = new List<string>();
            int n = 0;
            int remainingN = 0;
            int counter = 0;
            foreach (var word in strings)
            {
                n = (int)word[0];
                if(n < 48 || n > 57)
                {
                    newStrings.Add(word.Remove(0, remainingN));
                    newStrings.Add(">");
                    continue;
                }
                char c = (char)n;
                var myInt = int.Parse(c.ToString());
                if (myInt > word.Length)
                {
                    remainingN = myInt - word.Length;   
                    newStrings.Add(word.Remove(0, word.Length));
                }
                else
                {
                    if(myInt + remainingN > word.Length)
                    {
                        newStrings.Add(word.Remove(0, word.Length));
                        remainingN = remainingN - myInt;
                    }
                    else
                    {
                        newStrings.Add(word.Remove(0, myInt + remainingN));
                        remainingN = 0;
                    }
                }
                if(counter != strings.Count - 2)
                {
                    newStrings.Add(">");
                    counter++;
                }
            }
            Console.WriteLine(string.Join("", newStrings));
        }
    }
}
