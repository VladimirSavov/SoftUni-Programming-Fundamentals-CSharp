using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftRacer = array.Length / 2;
            double timeOnleftRacer = 0;
            for (int i = 0; i < leftRacer; i++)
            {
                if(array[i] == 0)
                {
                    timeOnleftRacer *= 0.8;
                }
                else
                {
                    timeOnleftRacer += array[i];
                }
            }
            int rightRacer = array.Length / 2;
            double timeOnRightRacer = 0;
            for (int i = array.Length / 2 + 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    timeOnRightRacer *= 0.8;
                }
                else
                {
                    timeOnRightRacer += array[i];
                }
            }
            if(timeOnleftRacer < timeOnRightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {timeOnleftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeOnRightRacer}");
            }
        }
    }
}



