using System;
using System.Collections.Generic;
using System.Text;

namespace CG_11_2__Student_Grades_
{
    public class Student
    {
        //properties for student class, the Scores property will be a list if integers
        public string Name { get; set; }

        public List<int> Scores { get; set; }

        //constructor to sort out data types from text file
        public Student(string studentData)
        {
            string[] studentdataSplit = studentData.Split("; ");
            Scores = new List<int>();

            for (int i = 0; i < studentdataSplit.Length; i++)
            {
                if (i == 0)
                {
                    Name = studentdataSplit[i];
                }
                else
                {
                    int score = int.Parse(studentdataSplit[i]);
                    Scores.Add(score);
                }

            }

        }

        
        /// <summary>
        /// method to determine average grade for each student, adds all scores then divides by number of scores
        /// </summary>
        /// <returns>average grade for each student</returns>
        public decimal AverageGrade()
        {
            int totalScore = 0;
            foreach (int score in Scores)
            {
                totalScore += score;
            }
            return totalScore / Scores.Count;
        }

        //method to capitalize first letter of name of each student
        public string StudentNameCap()
        {
            return char.ToUpper(this.Name[0]) + this.Name.Substring(1);
        }

    }
}
