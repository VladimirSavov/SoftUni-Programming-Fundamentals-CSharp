using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            string digits = "";
            string letters = "";
            string otherChars = "";
            for (int i = 0; i < chars.Length; i++)
            {
                int charInInteger = chars[i];
                if(charInInteger >= 48 && charInInteger <= 57)
                {
                    digits += chars[i];
                }
                else if(charInInteger >= 65 && charInInteger <= 90 || charInInteger >= 97 && charInInteger <= 122)
                {
                    letters += chars[i];
                }
                else
                {
                    otherChars += chars[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
