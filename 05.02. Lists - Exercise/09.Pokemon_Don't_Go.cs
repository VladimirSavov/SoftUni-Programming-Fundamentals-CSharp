using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int sum = 0;
            int removeNum = 0;
            while(input.Count > 0)
            {
                bool skip = true;
                if (index < 0)
                {
                    input.RemoveAt(0);
                    currentNum = input[input.Count - 1];
                    input.Insert(0, currentNum);
                    index = input.Count - 1;
                    input.RemoveAt(input.Count - 1);
                    skip = false;
                    sum += index;
                }
                else if(index > input.Count - 1)
                {
                    currentNum = input[0];
                    input.RemoveAt(input.Count - 1);
                    input.Insert(input.Count - 1, currentNum);
                    index = input[0];
                    input.RemoveAt(0);
                    skip = false;
                    sum += index;
                }
                if (skip)
                {
                    removeNum = index;
                    index = input[index];
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if(index > input[i])
                    {
                        input[i] += index;
                    }
                    else if(index <= input[i])
                    {
                        input[i] -= index;
                    }
                }
                if (skip)
                {
                    sum += index;
                    input.RemoveAt(removeNum);
                }
                if (input.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());
            } 
            Console.WriteLine(sum);
        }
    }
}
