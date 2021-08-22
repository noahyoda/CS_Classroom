using System;

namespace Classroom
{
    public class Student
    {
        private String name;
        private int grade;
        private double gpa;
        private String notes;

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

        public double getGPA(){
            return gpa;
        }

        public void writeNotes(String stuNotes){
            this.notes = stuNotes;
        }

        public String getNotes(){
            return notes;
        }

        public String toString(){
            return name + "\t" + Convert.ToString(grade) + "\t" + Convert.ToString(gpa);
        }

    }
}