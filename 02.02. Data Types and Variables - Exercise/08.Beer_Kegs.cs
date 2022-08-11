using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string nameOfModel = "";

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if(volume > biggestKeg)
                {
                    biggestKeg = volume;
                    nameOfModel = model;
                }
            }
            Console.WriteLine(nameOfModel);
            
        }
    }
}
