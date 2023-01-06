using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //else if(charInInteger >= 65 && charInInteger <= 90 || charInInteger >= 97 && charInInteger <= 122)
            string[] input = Console.ReadLine().Split(", ").ToArray();
            foreach (string s in input)
            {
                bool isTrue = false;
                if(s.Length >= 3 && s.Length <= 16)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if ((s[i] == 45 || s[i] == 95) || (s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122) || (s[i] >= 48 && s[i] <= 57))
                        {
                            isTrue = true;
                        }
                        else
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    if (isTrue)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
