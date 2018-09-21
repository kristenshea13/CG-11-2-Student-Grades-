using System;
using System.Collections.Generic;
using System.Text;

namespace CG_11_2__Student_Grades_
{
    class Student
    {
        public string Name { get; set; }

        public List<int> Scores { get; set; }

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


        public decimal AverageGrade()
        {
            int totalScore = 0;
            foreach (int score in Scores)
            {
                totalScore += score;
            }
            return totalScore / Scores.Count;

        }

        public string StudentNameCap()
        {
            return char.ToUpper(this.Name[0]) + this.Name.Substring(1);

        }

    }
}
