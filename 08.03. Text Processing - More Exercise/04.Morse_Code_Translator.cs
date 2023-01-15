using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string output = "";
            foreach (var item in input)
            {
                switch (item)
                {
                    case ".-":
                        output += "A";
                        break;
                    case "-...":
                        output += "B";
                        break;
                    case "-.-.":
                        output += "C";
                        break;
                    case "-..":
                        output += "D";
                        break;
                    case ".":
                        output += "E";
                        break;
                    case "..-.":
                        output += "F";
                        break;
                    case "--.":
                        output += "G";
                        break;
                    case "....":
                        output += "H";
                        break;
                    case "..":
                        output += "I";
                        break;
                    case ".---":
                        output += "J";
                        break;
                    case "-.-":
                        output += "K";
                        break;
                    case ".-..":
                        output += "L";
                        break;
                    case "--":
                        output += "M";
                        break;
                    case "-.":
                        output += "N";
                        break;
                    case "---":
                        output += "O";
                        break;
                    case ".--.":
                        output += "P";
                        break;
                    case "--.-":
                        output += "Q";
                        break;
                    case ".-.":
                        output += "R";
                        break;
                    case "...":
                        output += "S";
                        break;
                    case "-":
                        output += "T";
                        break;
                    case "..-":
                        output += "U";
                        break;
                    case "...-":
                        output += "V";
                        break;
                    case ".--":
                        output += "W";
                        break;
                    case "-..-":
                        output += "X";
                        break;
                    case "-.--":
                        output += "Y";
                        break;
                    case "--..":
                        output += "Z";
                        break;
                    case "|":
                        output += " ";
                        break;
                        default:
                        break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
