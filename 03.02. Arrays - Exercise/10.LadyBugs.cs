using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cells = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] positions = new int[cells]; 

            for (int i = 0; i < cells; i++)
            {
                for (int k = 0; k < input.Length; k++)
                {
                    if (i == input[k])
                    {
                        positions[i] = 1;
                    }
                }
            }
            string command = Console.ReadLine(); 

            while (command != "end")
            {
                string[] transform = command.Split(); 
                int ladybugIndex = 0;
                int moveIndex = 0;
                string direction = string.Empty;

                for (int i = 1; i < 2; i++)
                {
                    if (transform[1] == "right")
                    {
                        direction = "right";
                    }
                    else if (transform[1] == "left")
                    {
                        direction = "left";
                    }
                    ladybugIndex = int.Parse(transform[0]); 
                    moveIndex = int.Parse(transform[2]); 

                }
                bool isDone = false;
                if (direction == "right")
                {
                    for (int i = 0; i < positions.Length; i++)
                    {
                        if ((i == ladybugIndex && positions[i] == 0)) 
                        {
                            break;
                        }
                        else if (moveIndex + ladybugIndex >= positions.Length || moveIndex + ladybugIndex < 0) 
                        {
                            positions[ladybugIndex] = 0;
                            break;
                        }
                        else if (positions[moveIndex + ladybugIndex] == 0)
                        {
                            positions[ladybugIndex] = 0;
                            positions[moveIndex + ladybugIndex] = 1;
                            isDone = true;
                            break;
                        }
                        else 
                        {
                            positions[ladybugIndex] = 0;
                            while (true)
                            {
                                if (moveIndex + ladybugIndex >= positions.Length || moveIndex + ladybugIndex < 0) // извън полето
                                {
                                    isDone = true;
                                    break;
                                }
                                else if (positions[moveIndex + ladybugIndex] == 1) // заето место и местене с 1 напред
                                {
                                    moveIndex += 1;
                                }
                                else if (positions[moveIndex + ladybugIndex] == 0)
                                {
                                    positions[moveIndex + ladybugIndex] = 1;
                                    isDone = true;
                                    break;
                                }
                            }
                        }
                        if (isDone == true)
                        {
                            break;
                        }
                    }
                }
                else if (direction == "left")
                {
                    for (int i = 0; i < positions.Length; i++)
                    {
                        if ((i == ladybugIndex && positions[i] == 0)) 
                        {
                            break;
                        }
                        else if (ladybugIndex - moveIndex >= positions.Length || ladybugIndex - moveIndex < 0) // извън полето
                        {
                            positions[ladybugIndex] = 0;
                            break;
                        }
                        else if (positions[ladybugIndex - moveIndex] == 0) 
                        {
                            positions[ladybugIndex] = 0;
                            positions[ladybugIndex - moveIndex] = 1;
                            isDone = true;
                            break;
                        }
                        else 
                        {
                            positions[ladybugIndex] = 0;
                            while (true)
                            {
                                if (ladybugIndex - moveIndex < 0 || ladybugIndex - moveIndex >= positions.Length) 
                                {
                                    isDone = true;
                                    break;
                                }
                                else if (positions[ladybugIndex - moveIndex] == 1) 
                                {
                                    moveIndex += 1;
                                }
                                else if (positions[ladybugIndex - moveIndex] == 0) 
                                {
                                    positions[ladybugIndex - moveIndex] = 1;
                                    isDone = true;
                                    break;
                                }
                            }
                        }
                        if (isDone == true)
                        {
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", positions));
        }
    }
        
    
}
