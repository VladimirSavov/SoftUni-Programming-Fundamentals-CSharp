using System;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            EnterItems(arr);
            Console.Write("Имената на населените места, които завършват на \"ovo\": ");
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length >= 3)
                {
                    int index1 = arr[i].IndexOf('o', arr[i].Length - 3);
                    int index2 = arr[i].IndexOf('v', arr[i].Length - 2);
                    int index3 = arr[i].IndexOf('o', arr[i].Length - 1);
                    if (index1 > 0 && index2 > 2 && index3 > 0)
                    {
                        Console.Write($"{arr[i]}, ");
                    }
                }
            }

        }
        static string[] EnterItems(string[] arr)
        {
            Console.WriteLine("Въведете имена на населени места: ");
            for (int i = 0; i < arr.Length; i++)
            {
                string nameOfCity = Console.ReadLine();
                arr[i] = nameOfCity;
            }
            return arr;
        }
    }
}
