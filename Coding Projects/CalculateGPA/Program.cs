namespace CalculateGPA;
class Program
{
    static void Main(string[] args)
    {
        // To calculate the GPA:
        //     Multiply the grade value for a course by the number of credit hours for that course.
        //     Do this for each course, then add these results together.
        //     Divide the resulting sum by the total number of credit hours.

        // The given setup:
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int course1Grade = 4;
        int course2Grade = 3;
        int course3Grade = 3;
        int course4Grade = 3;
        int course5Grade = 4; 

        int course1result = course1Credit * course1Grade;
        int course2result = course2Credit * course2Grade;
        int course3result = course3Credit * course3Grade;
        int course4result = course4Credit * course4Grade;
        int course5result = course5Credit * course5Grade;

        int courseTotal = course1result + course2result + course3result + course4result + course5result;
        float finalGPA = (float)courseTotal / (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\tGrade\tCredit Hours");
        Console.WriteLine($"Final GPA: {finalGPA}");
    }
} 
