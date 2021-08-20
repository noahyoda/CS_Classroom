using System;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Classroom project!");
            while(true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Add a student\n2 - Remove a student\n3 - List all students\n4 - Export students to file\n5 - Exit");
            }
        }
    }
}
