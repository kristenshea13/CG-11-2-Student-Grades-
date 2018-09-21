using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_2__Student_Grades_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using the text file studentdata.txt write a program that calculates the average grade for 
            //each student, and print out the student’s name along with their average grade.Be sure to use a Student class.

            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-2 (Student Grades)\CG 11-2 (Student Grades)\studentdata.txt");

            List<Student> studentData = new List<Student>();

            foreach (string item in students)
            {
                studentData.Add(new Student(item));

            }

            Console.WriteLine("Student average grades: ");

            foreach (Student student in studentData)
            {

                Console.WriteLine($"{student.StudentNameCap()}: {student.AverageGrade()}");
            }


            Console.ReadLine();

        }
    }
}
