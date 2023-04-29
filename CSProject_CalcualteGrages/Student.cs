using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSProject_CalcualteGrages
{
    public class Student
    {
        string name;
        int[] grades;
        decimal averageGrade;
        char gradeLetter;
        int currentAssignments = 5;

        public Student(string Name, int[] Grades)
        {
            name = Name;
            grades = Grades;
        }

        public void CalculateGradeAvg()
        {
            decimal total = 0;
            foreach (int grade in grades)
            {
                total += grade;
            }
            averageGrade = total / currentAssignments;

            switch(averageGrade)
            {
                case >= 90: 
                    gradeLetter = 'A';
                    break;
                case >= 80: 
                    gradeLetter = 'B';
                    break;
                case >= 70: 
                    gradeLetter = 'C';
                    break;
                case >= 60: 
                    gradeLetter = 'D';
                    break;
                case < 60:
                    gradeLetter = 'F';
                    break;
            }
        }

        public void DisplayGradeRecord()
        {
            CalculateGradeAvg();
            Console.WriteLine($"{name};\t{averageGrade}\t{gradeLetter}");
        }        
    }
}