namespace CSProject_CalcualteGrages;
class Program
{
    static void Main(string[] args)
    {
        // Requirements:
        // You're developing a Student Grading application that automates the calculation of current grades for each student in a class. 
        // The parameters for your application are:
        //     You're given a short list of four students and their five assignment grades.
        //     Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
        //     Final scores are calculated as an average of the five assignment scores.
        //     Your application needs to perform basic math operations to calculate the final grades for each student.
        //     Your application needs to output/display each student’s name and final score.
        // Expected Output: 
        //      Student     Grade
        //      Sophia      94.6  A
        //      Nicolas     83.6  B
        //      Zahirah     83.4  B
        //      Jeong       95.4  A

        // Grades: 
        int[] SophiaGrades = {93, 87, 98, 95, 100};
        int[] NicolasGrades = {80, 83, 82, 88, 85};
        int[] ZahirahGrades = {84, 96, 73, 85, 79};
        int[] JeongGrades = {90, 92, 98, 100, 97};

        Student Sophia = new Student("Sophia", SophiaGrades);
        Student Nicolas = new Student("Nicolas", NicolasGrades);
        Student Zahirah = new Student("Zahirah", ZahirahGrades);
        Student Jeong = new Student("Jeong", JeongGrades);  
        Student[] myStudents = {Sophia, Nicolas, Zahirah, Jeong};

        Console.WriteLine("Student\tGrade");
        foreach(Student student in myStudents)
        {
            student.DisplayGradeRecord();
        }
    }
}
