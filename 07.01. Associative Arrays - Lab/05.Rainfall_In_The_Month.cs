using System;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой дни в месеца: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Въведете валежите за станция A");
            RainfallInTheMonth(arr, n);
            int[] A = arr;
            int[] input = A;
            double averageOfStationA = ArithmeticMean(input, n);
            Console.WriteLine("Въведете валежите за станция B");
            RainfallInTheMonth(arr, n);
            int[] B = arr;
            input = B;
            double averageOfStationB = ArithmeticMean(input, n);
            Console.WriteLine("Въведете валежите за станция C");
            RainfallInTheMonth(arr, n);
            int[] C = arr;
            input = C;
            double averageOfStationC = ArithmeticMean(input, n);
            double averageForAllStations = (averageOfStationA + averageOfStationB + averageOfStationC) / 3;
            Console.WriteLine($"Средното количество валежи в месеца за станция A е: {averageOfStationA}");
            Console.WriteLine($"Средното количество валежи в месеца за станция B е: {averageOfStationB}");
            Console.WriteLine($"Средното количество валежи в месеца за станция C е: {averageOfStationC}");
            Console.WriteLine($"Общото средно количество валежи в месеца е: {averageForAllStations}");
        }

        static int[] RainfallInTheMonth(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            return arr;
        }
        static double ArithmeticMean(int[] input, int n)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            double average = sum / n;
            return average;
        }
    }
}
