using System;

namespace Classroom
{
    public class Student
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
            return name + "\t" + Convert.ToString(grade);
        }

        public double getGPA(){
            return gpa;
        }

    }
}