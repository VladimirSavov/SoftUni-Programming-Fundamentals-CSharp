using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(list1.Count >= list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if(list2.Count == i)
                    {
                        while (list1.Count != i)
                        {
                            Console.Write($"{list1[i]} ");
                            i++;
                        }
                        break;
                    }
                    Console.Write($"{list1[i]} ");
                    Console.Write($"{list2[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list1.Count == i)
                    {
                        while (list2.Count != i)
                        {
                            Console.Write($"{list2[i]} ");
                            i++;
                        }
                        break;
                    }
                    Console.Write($"{list1[i]} ");
                    Console.Write($"{list2[i]} ");
                }
            }
        }
    }
}
