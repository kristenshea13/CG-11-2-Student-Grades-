using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_2__Student_Grades_
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads text file  with student info
            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-2 (Student Grades)\CG 11-2 (Student Grades)\studentdata.txt");

            //initiate list for all instances of student class
            List<Student> studentData = new List<Student>();

            //loop to add data from text file to list
            foreach (string item in students)
            {
                studentData.Add(new Student(item));
            }

            Console.WriteLine("Average scores for each student: ");
            Console.WriteLine();

            //loop to print out average grades of each student
            foreach (Student student in studentData)
            {
                Console.WriteLine($"{student.StudentNameCap()}: {student.AverageGrade()}");
            }


            Console.ReadLine();

        }
    }
}
