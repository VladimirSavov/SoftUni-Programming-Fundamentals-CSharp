using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string number = "";
            int letterPosition = 1;
            int currLetterPosition = 0;
            double sum = 0;
            double numberInInt = 0;
            foreach (var item in input)
            {
                sum += numberInInt;
                string word = item.Trim();
                number = "";
                for (int i = 1; i < word.Length - 1; i++)
                {
                    number += word[i];
                }   
                char c = word[0];
                numberInInt = int.Parse(number);
                if (c >= 65 && c <= 90)
                {
                    letterPosition = c - 64;
                    numberInInt /= letterPosition;
                }
                else if(c >= 97 && c<= 122)
                {
                    letterPosition = c - 96;
                    numberInInt *= letterPosition;
                }
                char w = word[word.Length - 1];
                if (w >= 65 && w <= 90)
                {
                    letterPosition = w - 64;
                    numberInInt -= letterPosition;
                }
                else if (w >= 97 && w <= 122)
                {
                    letterPosition = w - 96; 
                    numberInInt += letterPosition;
                }
            }
            sum += numberInInt;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
