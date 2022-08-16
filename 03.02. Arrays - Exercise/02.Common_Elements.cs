using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            foreach (var item in arrOne)
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    string secondCurElement = arrTwo[i];
                    if(secondCurElement == item)
                    {
                        Console.Write($"{item} ");
                        break;
                    }
                }
            }

        }
    }
}
