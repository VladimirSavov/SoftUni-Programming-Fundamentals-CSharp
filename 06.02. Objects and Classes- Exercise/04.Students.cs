using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                input = command.Split().ToList();
                Student student = new Student();
                {
                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Grade = input[2];
                }
                students.Add(student);
                command = Console.ReadLine();
            }
            List<Student> sortedstudents = students.OrderBy(sort => sort.Grade).ToList();
            sortedstudents.Reverse();
            foreach (Student student in sortedstudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
    }
}
