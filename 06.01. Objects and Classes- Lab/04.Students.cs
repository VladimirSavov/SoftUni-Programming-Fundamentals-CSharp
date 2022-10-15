using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Threading;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentInformation = new List<Student>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> input = command.Split().ToList();
                string firstName = input[0];
                string lastName = input[1];
                string age = input[2];
                string homeTown = input[3];

                Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    studentInformation.Add(student);

                command = Console.ReadLine();
                }
                string cityName = Console.ReadLine();
                foreach (Student student in studentInformation)
                {
                    if(student.HomeTown == cityName)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                    }
                }
            }
        }
    }
    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }

        public string HomeTown { get; set; }
    }




