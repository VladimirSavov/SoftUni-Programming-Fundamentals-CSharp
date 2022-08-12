using System;
namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int countheadsetTrash = 0;
            int countmouseTrash = 0;
            int countkeyboardTrash = 0;
            int countdisplayTrash = 0;
            int counter = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if(i % 2 == 0)
                {
                    countheadsetTrash++;
                }
                if(i % 3 == 0)
                {
                    countmouseTrash++;
                }
                if(i % 6 == 0)
                {
                    countkeyboardTrash++;
                    counter++;
                    if (counter % 2 == 0 && counter != 0)
                    {
                        countdisplayTrash++;
                    }

                }
            }
            Console.WriteLine($"Rage expenses: {(headsetPrice * countheadsetTrash) + (mousePrice * countmouseTrash) + (keyboardPrice * countkeyboardTrash) + (displayPrice * countdisplayTrash):F2} lv.");
        }
    }
}
