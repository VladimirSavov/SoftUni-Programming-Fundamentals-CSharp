using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNum; i <= 10; i++)
            {
                sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
            }
            if(startNum > 10)
            {
                Console.WriteLine($"{num} X {startNum} = {num * startNum}");
            }
        }
    }
}
