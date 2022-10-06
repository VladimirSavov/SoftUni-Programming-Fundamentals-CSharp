using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "Go" && command[1] != "Shopping!")
            {
                if (command[0] == "Urgent")
                {
                    if (products.Contains(command[1]))
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    else
                    {
                        products.Add(command[1]);   
                    }
                }
                else if(command[0] == "Unnecessary")
                {
                    if (products.Contains(command[1]))
                    {
                        products.Remove(command[1]);
                    }
                    else
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (products.Contains(command[1]))
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i] == command[1])
                            {
                                products.Remove(command[i]);
                                products.Insert(i, command[2]);
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (products.Contains(command[1]))
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i] == command[1])
                            {
                                products.Remove(command[i]);
                                products.Insert(products.Count - 1, command[2]);
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(", ", products));
        }
    }
}

