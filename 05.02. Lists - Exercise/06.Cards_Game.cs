using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> handOne = Console.ReadLine().Split().Select(int.Parse).ToList();
           List<int> handTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstCardInDeck = 0;
            int sum = 0;
            while(handOne.Count != 0 && handTwo.Count != 0)
            {
                if (handOne[0] > handTwo[0])
                {
                    firstCardInDeck = handOne[0];   
                    handOne.RemoveAt(0);
                    handOne.Add(firstCardInDeck);
                    handOne.Add(handTwo[0]);
                    handTwo.RemoveAt(0);
                }
                else if (handOne[0] < handTwo[0])
                {
                    firstCardInDeck = handTwo[0];
                    handTwo.RemoveAt(0);
                    handTwo.Add(firstCardInDeck);
                    handTwo.Add(handOne[0]);
                    handOne.RemoveAt(0);
                }
                else 
                {
                    handTwo.RemoveAt(0);
                    handOne.RemoveAt(0);
                }
            }

            if(handOne.Count > 0)
            {
                for (int i = 0; i < handOne.Count; i++)
                {
                    sum += handOne[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < handTwo.Count; i++)
                {
                    sum += handTwo[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
