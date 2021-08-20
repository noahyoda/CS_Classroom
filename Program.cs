using System;
using System.Collections;
using System.Collections.Generic;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Classroom project!");
            List<Student> classroom = new List<Student>();

            while(true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Add a student\n2 - Remove a student\n3 - List all students\n4 - Export students to file\n5 - Exit");
                int choice = Console.Read();

                switch (choice){
                    case 1:
                        Console.WriteLine("What is the students name:\n");
                        String name = Console.ReadLine();
                        Console.WriteLine("What is the students grade:\n");
                        int grade = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("And what is the students gpa:\n");
                        double gpa = Convert.ToDouble(Console.ReadLine());
                        Student newStudent = new Student(name, grade, gpa);
                        classroom.Add(newStudent);
                        Console.WriteLine("Student added successfully");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

            }
        }
    }
}
