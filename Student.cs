using System;

namespace Classroom
{
    class Student
    {
        private String name;
        private int grade;
        private double gpa;
        public Student(String name, int grade, double gpa){
            this.name = name;
            this.grade = grade;
            this.gpa = gpa;
        }

        public String getName(){
            return this.name;
        }

        public int getGrade(){
            return this.grade;
        }

        public String toString(){
            String whole = name + "\t" + (String)grade;
        }

        public double getGPA(){
            return gpa;
        }

    }
}