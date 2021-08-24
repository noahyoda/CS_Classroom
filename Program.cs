using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Classroom
{
    class Program
    {
        /*
        * TODO:
        * Add option to choose what file to export students to
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Classroom project!");
            List<Student> classroom = new List<Student>();

            bool running = true;
            while(running){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Add a student\n2 - Remove a student\n3 - List all students\n4 - Export students to file\n5 - Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice){
                    case 1:
                        addStudent(classroom);
                        break;
                    case 2:
                        removeStudent(classroom);
                        break;
                    case 3:
                        printClassroom(classroom);
                        break;
                    case 4:
                        Console.WriteLine("Do you want to use the default file (y/n):");
                        String select = Console.ReadLine();
                        if(select.ToLower() == "y")
                            exportStudents(classroom, "classroom.txt");
                        else{
                            Console.WriteLine("What is your desired file (include file type)");
                            String exportFile = Console.ReadLine();
                            if(!exportFile.Contains(".")){
                                Console.WriteLine("Error: did not include file extension type!");
                                break;
                            }
                            exportStudents(classroom, exportFile);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        running = false;
                        break;
                }

            }
            
        }

        public static void exportStudents(List<Student> room, String location){
            try{
                StreamWriter sw = new StreamWriter(location);
                foreach(Student stu in room){
                    sw.WriteLine(stu.toString());
                }
                sw.Close();
                Console.WriteLine("Exported Successfully to " + location);
            } catch(FileNotFoundException f){
                File.Create(location);
                exportStudents(room, location);
            } catch(Exception e){
                Console.WriteLine("File Error: " + e.Message);
            }
        }

        public static void addStudent(List<Student> room){
            Console.WriteLine("What is the students name:\n");
            String name = Console.ReadLine();
            Console.WriteLine("What is the students grade:\n");
            int grade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("And what is the students gpa:\n");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Student newStudent = new Student(name, grade, gpa);
            room.Add(newStudent);
            Console.WriteLine("Student added successfully");
        }

        public static void removeStudent(List<Student> room){
            Console.WriteLine("Which student do you want to remove:\n");
            String name = Console.ReadLine();
            foreach(Student s in room){
                if(s.getName() == name){
                    room.Remove(s);
                    return;
                }
            }
            Console.WriteLine("Error, Student does not exis!\nRemember to check the spelling and capitalization");
        }

        public static void printClassroom(List<Student> room){
            String x = "";
            foreach(Student stu in room){
                x += stu.getName() + "\t" + stu.getGPA() + "\t" + stu.getGrade();
            }
            Console.WriteLine(x);
        }

    }
}
