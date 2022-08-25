using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] inputAsArray = inputCommand.Split().ToArray(); 

                if (inputAsArray[0] == "exchange") 
                {
                    if (int.Parse(inputAsArray[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    int splitIndex = int.Parse(inputAsArray[1]) + 1;
                    if (splitIndex > array.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] subArray1 = new int[splitIndex];
                        int[] subArray2 = new int[array.Length - splitIndex];
                        for (int i = 0; i < subArray1.Length; i++)
                        {
                            subArray1[i] = array[i];
                        }
                        for (int k = 0; k < subArray2.Length; k++)
                        {
                            subArray2[k] = array[k + splitIndex];
                        }
                        for (int l = 0; l < subArray2.Length; l++)
                        {
                            array[l] = subArray2[l];
                        }
                        for (int m = 0; m < subArray1.Length; m++)
                        {
                            array[m + subArray2.Length] = subArray1[m];
                        }
                    }
                }
                else if (inputAsArray[0] == "max") 
                {
                    int maxValueOdd = int.MinValue;
                    int maxValueEven = int.MinValue;
                    int counterEven = 0;
                    int counterOdd = 0;
                    int evenIndex = 0;
                    int oddIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            if (array[i] >= maxValueEven)
                            {
                                maxValueEven = array[i];
                                evenIndex = i;
                                counterEven++;
                            }
                        }
                        else
                        {
                            if (array[i] >= maxValueOdd)
                            {
                                maxValueOdd = array[i];
                                oddIndex = i;
                                counterOdd++;
                            }
                        }
                    }
                    if (inputAsArray[1] == "even")
                    {
                        if (counterEven == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(evenIndex);
                        }

                    }
                    else if (inputAsArray[1] == "odd")
                    {
                        if (counterOdd == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(oddIndex);
                        }
                    }
                }
                else if (inputAsArray[0] == "min") 
                {
                    int minValueOdd = int.MaxValue;
                    int minValueEven = int.MaxValue;
                    int counterEven = 0;
                    int counterOdd = 0;
                    int evenIndex = 0;
                    int oddIndex = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            if (array[i] <= minValueEven)
                            {
                                minValueEven = array[i];
                                evenIndex = i;
                                counterEven++;
                            }
                        }
                        else
                        {
                            if (array[i] <= minValueOdd)
                            {
                                minValueOdd = array[i];
                                oddIndex = i;
                                counterOdd++;
                            }
                        }
                    }
                    if (inputAsArray[1] == "even")
                    {
                        if (counterEven == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(evenIndex);
                        }

                    }
                    else if (inputAsArray[1] == "odd")
                    {
                        if (counterOdd == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(oddIndex);
                        }
                    }
                }

                else if (inputAsArray[0] == "first")
                {
                    int counter = 0;
                    int arrayIndex = int.Parse(inputAsArray[1]);
                    if (int.Parse(inputAsArray[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }

                    else if (inputAsArray[2] == "even")
                    {
                        int arrayCounter = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                arrayCounter++;
                            }
                        }
                        if (arrayCounter < int.Parse(inputAsArray[1]))
                        {
                            arrayIndex = arrayCounter;
                        }

                        int[] firstEvenArray = new int[arrayIndex];
                        int index = 0;
                        for (int k = 0; k < array.Length; k++)
                        {
                            if (array[k] % 2 == 0)
                            {
                                firstEvenArray[index] = array[k];
                                counter++;
                                index++;
                                if (counter == arrayIndex)
                                {
                                    break;
                                }
                            }
                        }

                        if (counter == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", firstEvenArray)}]");
                        }
                    }

                    else if (inputAsArray[2] == "odd")
                    {
                        int arrayCounter = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                arrayCounter++;
                            }
                        }
                        if (arrayCounter < int.Parse(inputAsArray[1]))
                        {
                            arrayIndex = arrayCounter;
                        }

                        int[] firstOddArray = new int[arrayIndex];
                        int index = 0;
                        for (int k = 0; k < array.Length; k++)
                        {
                            if (array[k] % 2 != 0)
                            {
                                firstOddArray[index] = array[k];
                                counter++;
                                index++;
                                if (counter == arrayIndex)
                                {
                                    break;
                                }
                            }
                        }

                        if (counter == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", firstOddArray)}]");
                        }
                    }
                }

                else if (inputAsArray[0] == "last")
                {
                    int counter = 0;
                    int arrayIndex = int.Parse(inputAsArray[1]);
                    if (int.Parse(inputAsArray[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }

                    else if (inputAsArray[2] == "even")
                    {
                        int arrayCounter = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                arrayCounter++;
                            }
                        }
                        if (arrayCounter < int.Parse(inputAsArray[1]))
                        {
                            arrayIndex = arrayCounter;
                        }

                        int[] lastEvenArray = new int[arrayIndex];
                        int index = 0;
                        for (int k = array.Length - 1; k >= 0; k--)
                        {
                            if (array[k] % 2 == 0)
                            {
                                lastEvenArray[index] = array[k];
                                counter++;
                                index++;
                                if (counter == arrayIndex)
                                {
                                    break;
                                }
                            }
                        }

                        if (counter == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", lastEvenArray.Reverse())}]");
                        }
                    }

                    else if (inputAsArray[2] == "odd")
                    {
                        int arrayCounter = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                arrayCounter++;
                            }
                        }
                        if (arrayCounter < int.Parse(inputAsArray[1]))
                        {
                            arrayIndex = arrayCounter;
                        }

                        int[] lastOddArray = new int[arrayIndex];
                        int index = 0;
                        for (int k = array.Length - 1; k >= 0; k--)
                        {
                            if (array[k] % 2 != 0)
                            {
                                lastOddArray[index] = array[k];
                                counter++;
                                index++;
                                if (counter == arrayIndex)
                                {
                                    break;
                                }
                            }
                        }

                        if (counter == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", lastOddArray.Reverse())}]");
                        }
                    }
                }

                inputCommand = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
